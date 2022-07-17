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

        /*
         * TODO : modificare i commenti una volta rimossa la lista statica
         *      : aggiungere i file di servizio 'Service' (dependency injection)
         *      : generazione automatica dell'iban con un metodo private
         */

        // Lista statica di prova per controllare le opearzioni CRUD
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
        public IActionResult GetAllUtenti()
        {
            return Ok(Utenti);
        }

        [HttpPost]
        // Metodo che aggiunge un utente alla lista statica 'Utenti'
        public IActionResult AddUtente(Utente newUtente)
        {
            Utenti.Add(newUtente);

            return Ok(Utenti);
        }

        [HttpDelete("{iban}")]
        // Metodo che rende il parametro dell'utente selezionato come 'false' (soft delete)
        public IActionResult DeleteUtente(string iban)
        {
            // La variabile contiene un oggetto di tipo Utente selezionandolo l'id con il metodo 'FirstOrDefault'
            Utente utente = Utenti.FirstOrDefault(u => u.iban == iban);
            //
            utente.Attivo = false;

            return Ok(Utenti);
        }

        [HttpPut]
        // Metodo che aggiorna l'utente selezionato nella variabile 'utente', modificandone tutti i parametri, quelli non modificati, si sostituiscono lo stesso di default
        public IActionResult UpdateUtente(Utente updateUtente)
        {
            Utente utente = Utenti.FirstOrDefault(u => u.iban == updateUtente.iban);

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
