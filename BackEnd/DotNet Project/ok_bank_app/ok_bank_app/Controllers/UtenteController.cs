using Microsoft.AspNetCore.Mvc;
using ok_bank_app.Models;
using ok_bank_app.Services.UtenteService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ok_bank_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtenteController : ControllerBase
    {

        /*
         * TODO : modificare i commenti una volta rimossa la lista statica
         *      : aggiungere i file di servizio 'Service' (dependency injection) [FATTO]
         *      : generazione automatica dell'iban con un metodo private
         */

        // Lista statica di prova per controllare le opearzioni CRUD

        private readonly IUtenteService _utenteService;

        public UtenteController(IUtenteService utenteService)
        {
            _utenteService = utenteService;
        }

        private static List<Utente> Utenti = new List<Utente>
        {
            new Utente(),
            new Utente
            {
                iban = "IT99C1234567890123456780002",
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
        // Metodo che ritorna la lista statica 'Utenti'
        public async Task<IActionResult> GetAllUtenti()
        {
            return Ok(await _utenteService.GetAllUtenti());
        }

        [HttpPost]
        // Metodo che aggiunge un utente alla lista statica 'Utenti'
        public async Task<IActionResult> AddUtente(Utente newUtente)
        {
            return Ok(await _utenteService.AddUtente(newUtente));
        }

        [HttpDelete("{iban}")]
        // Metodo che rende il parametro dell'utente selezionato come 'false' (soft delete)
        public async Task<IActionResult> DeleteUtente(string iban)
        {
            return Ok(await _utenteService.DeleteUtente(iban));
        }

        [HttpPut]
        // Metodo che aggiorna l'utente selezionato nella variabile 'utente', modificandone tutti i parametri, quelli non modificati, si sostituiscono lo stesso di default
        public async Task<IActionResult> UpdateUtente(Utente updateUtente)
        {
            return Ok(await _utenteService.UpdateUtente(updateUtente));
        }
    }
}
