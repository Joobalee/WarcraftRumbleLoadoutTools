using System.Text.Json;
using WarcraftRumbleLoadoutTools;
namespace WarcraftRumbleLoadoutExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------Import Loadout Example----------

            //Import the loadout from the loadout code
            var importedLoadout = Loadout.LoadoutFromCode("rumblo:CEMQABoECCYQAhoECBUQABoECF0QARoECAkQABoECB4QABoECFYQAQ==");
            //Write the loadout as JSON to the console
            Console.WriteLine(JsonSerializer.Serialize(importedLoadout, new JsonSerializerOptions { WriteIndented = true }));

            //--------Export Loadout Example----------
            Console.WriteLine(""); //spacing

            //Create a new loadout with Sylvanas
            var createdLoadout = new Loadout(new Leader(WRMini.Sylvanas, 2));
            //Update the troops of the loadout
            createdLoadout.Troops = new List<Troop>
            {
                //Instantiate troop objects
                new Troop(WRMini.DireBatlings, WRMiniTalent.GuanoHappens),
                new Troop(WRMini.AngryChickens,WRMiniTalent.Snackrifice),
                new Troop(WRMini.Ghoul,WRMiniTalent.TasteForBlood),
                //Talents can use either WRMiniTalent enum, or a value from 0-2 to set the talent
                new Troop(WRMini.DeepBreath,1),
                new Troop (WRMini.ChainLightning,2),
                new Troop(WRMini.Necromancer,(byte)0) //0 is ambiguous between enums, ints, doubles etc so it needs to be casted as a byte in this case
            };
            Console.WriteLine(""); //spacing

            //Write name of all talents to console
            foreach (var t in createdLoadout.Troops)
            {
                Console.WriteLine(t.Talent);
            }
            Console.WriteLine(""); //spacing
            //Write loadout code to console
            string createdLoadoutCode = createdLoadout.GetCode();
            Console.WriteLine(createdLoadoutCode);
        }
    }
}
