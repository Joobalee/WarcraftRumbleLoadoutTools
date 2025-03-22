﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;
using System.Text.RegularExpressions;
using ProtoBuf;
using System.IO;
using System.Linq;

namespace WarcraftRumbleLoadoutTools
{
    [Serializable]
    [ProtoContract]
    public class Loadout
    {
        public Leader Leader { get; set; } = new Leader();
        [ProtoMember(1)]
        private int LeaderID { get => (int)Leader.Mini; set => Leader.Mini = Enum.Parse<WRMini>(value.ToString()); }
        [ProtoMember(2)]
        private int? LeaderTalentId { get => Leader.Talent != null ? (int?)Leader.Talent : null; set => Leader.TalentID = value; }
        [ProtoMember(3)]
        public List<Troop> Troops { get; set; } = new List<Troop>();

        public Loadout()
        {
                
        }
        public Loadout(Leader l)
        {
            Leader = l;
        }
        public Loadout(Leader l, List<Troop> t)
        {
            Leader = l;
            Troops = t;
        }
        public static Loadout? LoadoutFromCode(string code)
        {
            Regex regex = new Regex("rumblo:");
            code = regex.Replace(code, "");

            byte[] bytes = Convert.FromBase64String(code);
            using (var stream = new MemoryStream(bytes))
            {
                var result = Serializer.Deserialize<Loadout>(stream);
                return result;
            }
        }

        public string GetCode()
        {
            byte[] bytes = new byte[] { };
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream,this);
                bytes = stream.GetBuffer().Take((int)stream.Length).ToArray();
            }
            return "rumblo:" + Convert.ToBase64String(bytes.ToArray());
        }
    }
}
