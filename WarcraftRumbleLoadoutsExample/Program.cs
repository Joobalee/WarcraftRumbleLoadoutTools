using System.Text.Json;
using WarcraftRumbleLoadoutTools;
namespace WarcraftRumbleLoadoutExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------Import Loadout Example----------

            //Import the loadout from the loadout code. This is an Onu deck featuring Faerie dragon, bog beast, priestess, execute, batlings and grunts
            var importedLoadout = Loadout.LoadoutFromCode("rumblo:CEMQABoECCYQAhoECBUQABoECF0QARoECAkQABoECB4QABoECFYQAQ==");
            //Write the loadout as JSON to the console
            Console.WriteLine(JsonSerializer.Serialize(importedLoadout, new JsonSerializerOptions { WriteIndented = true }));

            //--------Export Loadout Example----------
            Console.WriteLine(""); //spacing

            //Create a new loadout with Thrall
            var createdLoadout = new Loadout(new Leader(WRMini.Thrall, WRMiniTalent.CallOfTheHorde));
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
                new Troop(WRMini.Necromancer,0)
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
