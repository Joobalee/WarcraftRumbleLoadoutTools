using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;
using System.Text.RegularExpressions;

namespace WarcraftRumbleLoadoutTools
{
    [Serializable]
    public class Loadout
    {
        public Leader Leader { get; set; }
        public List<Troop> Troops { get; set; } = new List<Troop>();
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
            Match match = regex.Match(code);
            code = regex.Replace(code, "");

            byte[] bytes = Convert.FromBase64String(code);
            var protobuf = ProtobufTool.ProcessProtobufMessage(bytes);
            List<Troop> troops = new List<Troop>();
            Leader? leader = null;
            for (int i = 0; i < protobuf.Count; i ++)
            {
                var v = protobuf[i];
                if (i == 0)
                {
                    leader = new Leader(Enum.Parse<WRMini>(v.Value.ToString()));
                    if (protobuf[i+1].Key == 2)
                    {
                        leader.TalentByte = protobuf[i + 1].Value;
                        i++;
                    }
                }
                else if (i > 0)
                {
                    var troop = new Troop(Enum.Parse<WRMini>(v.Value.ToString()));
                    if (i != protobuf.Count - 1 && protobuf[i + 1].Key == 2)
                    {
                        troop.TalentByte = protobuf[i + 1].Value;
                        i++;
                    }
                    troops.Add(troop);
                }
            }


            //Old algorithm. Delete later
            /*
            byte readMiniByte = 8;
            byte readTalentByte = 16;
            //byte nextReadByte = 26;
            byte talentTrueByte = 4;
            byte talentFalseByte = 2;

            for (int i = 0; i < bytes.Length-1; i++)
            {
                byte b = bytes[i];
                if(i == 1)
                {
                    if (bytes[i+1] == readTalentByte)
                    {
                        leader = new Leader(Enum.Parse<WRMini>(b.ToString()), bytes[i+2]);
                    }
                    else
                    {
                        leader = new Leader(Enum.Parse<WRMini>(b.ToString()));
                    }

                }
                if((b == talentTrueByte || b == talentFalseByte) && bytes[i+1] == readMiniByte)
                {
                    if(b == talentTrueByte)
                    {
                        troops.Add(new Troop(Enum.Parse<WRMini>(bytes[i + 2].ToString()), bytes[i+4]));
                    }
                    else if(b == talentFalseByte)
                    {
                        troops.Add(new Troop(Enum.Parse<WRMini>(bytes[i+2].ToString())));
                    }

                    
                }

            }
            */
            if (leader != null)
            {
                return new Loadout(leader, troops);
            }
            else
            {
                return null;
            }
        }

        public string GetCode()
        {
            //TODO: replace with protobuf
            byte readMiniByte = 8;
            byte readTalentByte = 16;
            byte nextReadByte = 26;
            byte talentTrueByte = 4;
            byte talentFalseByte = 2;
            List<byte> bytes = new List<byte>();

            bytes.Add(readMiniByte);
            bytes.Add((byte)Leader.Mini);
            if (Leader.TalentByte != null)
            {
                bytes.Add(readTalentByte);
                bytes.Add((byte)Leader.TalentByte);
                bytes.Add(nextReadByte);
            }
            for (int i = 0; i < Troops.Count; i++)
            {
                Troop t = Troops[i];
                if (t.TalentByte != null)
                {
                    bytes.Add(talentTrueByte);
                }
                else
                {
                    bytes.Add(talentFalseByte);
                }
                bytes.Add(readMiniByte);
                bytes.Add((byte)t.Mini);
                if (t.TalentByte != null)
                {
                    bytes.Add(readTalentByte);
                    bytes.Add((byte)t.TalentByte);
                }
                if (i != Troops.Count - 1)
                    bytes.Add(nextReadByte);
            }
            string s = "rumblo:" + Convert.ToBase64String(bytes.ToArray());
            return "rumblo:" + Convert.ToBase64String(bytes.ToArray());
        }
    }
}
