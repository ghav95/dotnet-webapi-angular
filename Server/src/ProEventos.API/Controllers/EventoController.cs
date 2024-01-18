using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Get: get example";
        }
        
        [HttpPost]
        public string Post()
        {
            return "Post: post example";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put: put example {id}";
        }
        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete: delete example {id}";
        }
    }
}
