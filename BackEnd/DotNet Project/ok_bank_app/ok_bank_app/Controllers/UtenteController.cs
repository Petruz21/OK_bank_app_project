using Microsoft.AspNetCore.Mvc;
using ok_bank_app.Models;
using System.Collections.Generic;
using System.Linq;

namespace ok_bank_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtenteController : ControllerBase
    {

        private static List<Utente> Utenti = new List<Utente>
        {
            new Utente(),
            new Utente
            {
                Id = 1,
                Nome = "Andrei",
                Cognome = "Petrut",
                Eta = "18",
                CodiceFiscale = "PTRMLN01B24Z129Q",
                numeroCI = "IA432IE",
                Paese = "Italia",
                Regione = "Piemonte",
                Provincia = "Torino",
                Comune = "Torino",
                Via = "Porpora",
                NumeroCivico = "55",
                Cap = "10154"
            }
        };

        [HttpGet]
        public IActionResult GetAllUtenti()
        {
            return Ok(Utenti);
        }

        [HttpPost]
        public IActionResult AddUtente(Utente newUtente)
        {
            Utenti.Add(newUtente);

            return Ok(Utenti);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUtente(int id)
        {
            Utente utente = Utenti.FirstOrDefault(u => u.Id == id);
            Utenti.Remove(utente);

            return Ok(Utenti);
        }

        [HttpPut]
        public IActionResult UpdateUtente(Utente updateUtente)
        {
            Utente utente = Utenti.FirstOrDefault(u => u.Id == updateUtente.Id);

            utente.Nome = updateUtente.Nome;
            utente.Cognome = updateUtente.Cognome;
            utente.Eta = updateUtente.Eta;
            utente.CodiceFiscale = updateUtente.CodiceFiscale;
            utente.numeroCI = updateUtente.numeroCI;
            utente.Paese = updateUtente.Paese;
            utente.Regione = updateUtente.Regione;
            utente.Provincia = updateUtente.Provincia;
            utente.Comune = updateUtente.Comune;
            utente.Via = updateUtente.Via;
            utente.NumeroCivico = updateUtente.NumeroCivico;
            utente.Cap = updateUtente.Cap;

            return Ok(Utenti);
        }
    }
}
