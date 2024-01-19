using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

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
        public IEnumerable<Evento> Get()
        {
            return new Evento[]{
                new Evento() {
                    Id = 1,
                    Tema = "Angular e .NET 5",
                    Local = "São Paulo",
                    Lote = "1",
                    QtdPessoas = 1,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "img.png"
                }
            };
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
