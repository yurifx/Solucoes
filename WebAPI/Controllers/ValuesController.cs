using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors; //necessário baixar o pacote via nugget
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [EnableCors(origins: "", headers: "", methods: "*")]
    public class ValuesController : Controller
    {

        //
        //WebAPI & Consumir via cross domain
        //
        // 1: Necessário baixar pacote .CORS.
        //
        // 2: Adicionar ao arquivo WebApiConfig.cs config.EnableCors();
        //
        // 3: Adicionar o filtro/atributo acima da action -> [EnableCors(origins: "", headers: "", methods: "*")]
        //
        

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
