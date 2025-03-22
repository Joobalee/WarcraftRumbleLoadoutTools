using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WarcraftRumbleLoadoutTools;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarcraftRumbleLoadoutDiscordAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoadoutController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public string Get([FromQuery] string code)
        {
            var loadout = Loadout.LoadoutFromCode(code);
            return JsonSerializer.Serialize(loadout);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string code)
        {

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
