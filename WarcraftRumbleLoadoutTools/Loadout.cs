using System;
using System.Collections.Generic;
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
        private int? LeaderTalentID { get => Leader.TalentID; set => Leader.TalentID = value; }
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
        /// <summary>
        /// Create an object representation of a rumble deck from an existing code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Retrieve the formatted rumble deck code from the object representation of the loadout
        /// </summary>
        /// <returns></returns>
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
