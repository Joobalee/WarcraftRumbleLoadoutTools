
using System.Text.Json;
using WarcraftRumbleLoadoutTools;
namespace WarcraftRumbleLoadoutExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loadout l = Loadout.LoadoutFromCode("rumblo:CEMQABoECCYQAhoECBUQABoECF0QARoECAkQABoECB4QABoECFYQAQ==");
                                                        //CEgQAQQIEAEIBAgQAAQIEAEECBABBAgQAA==
            l.GetCode();
            Console.WriteLine(JsonSerializer.Serialize(l, new JsonSerializerOptions { WriteIndented = true }));

            var l2 = new Loadout(new Leader(WRMini.Sylvanas, 2));
            l2.Troops = new List<Troop>
            {
                new Troop(WRMini.DireBatlings, WRMiniTalent.GuanoHappens),
                new Troop(WRMini.AngryChickens,WRMiniTalent.Snackrifice),
                new Troop(WRMini.Ghoul,WRMiniTalent.TasteForBlood),
                new Troop(WRMini.DeepBreath,1),
                new Troop (WRMini.ChainLightning,2),
                new Troop(WRMini.Necromancer,1)
            };
            string s = l2.GetCode();
            foreach (var t in l2.Troops)
            {
                Console.WriteLine(t.Talent);
            }

        }
    }
}
