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

        public IEnumerable<Evento> _evento = new Evento[]
        {

                new Evento(){
                    EventoId = 1,
                    Local = "Sala 1",
                    DataEvento = "01/01/2020",
                    Tema = "Evento 1",
                    QtdPessoas = 20,
                    Lote = "Lote 1",
                    ImagemURL = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png"
                },
                new Evento(){
                    EventoId = 2,
                    Local = "Sala 2",
                    DataEvento = "02/01/2020",
                    Tema = "Evento 2",
                    QtdPessoas = 40,
                    Lote = "Lote 2",
                    ImagemURL = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png"
                },
                new Evento(){
                    EventoId = 3,
                    Local = "Sala 3",
                    DataEvento = "03/01/2020",
                    Tema = "Evento 3",
                    QtdPessoas = 60,
                    Lote = "Lote 3",
                    ImagemURL = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png"
                },
            };


        public EventoController()
        { }

        [HttpGet]     // GET api/evento
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]     // GET api/evento/1
        public Evento Get(int id)
        {
            return _evento.FirstOrDefault(e => e.EventoId == id);
        }




        [HttpPost]
        public string Post()
        {
            return "Take this ms Postman World";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Exemplo de Put com id: " + id;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Exemplo de Delete com id: " + id;
        }


    }
}
