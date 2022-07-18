using ok_bank_app.Models;
using ok_bank_app.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ok_bank_app.Services.UtenteService
{
    public class UtenteService : IUtenteService
    {
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
        public async Task<Response<Utente>> AddUtente(Utente newUtente)
        {
            Response<Utente> response = new Response<Utente>();
            Utente utente = newUtente;
            Utenti.Add(newUtente);
            response.Data = utente;

            return response;
        }

        public async Task<Response<Utente>> DeleteUtente(string iban)
        {
            Response<Utente> response = new Response<Utente>();
            Utente utente = Utenti.FirstOrDefault(u => u.iban == iban);
            utente.Attivo = false;
            response.Data = utente;

            return response;
        }

        public async Task<Response<List<Utente>>> GetAllUtenti()
        {
            Response<List<Utente> > response = new Response<List<Utente>>();
            response.Data = Utenti;

            return response;
        }

        public async Task<Response<Utente>> UpdateUtente(Utente updateUtente)
        {
            Response<Utente> response = new Response<Utente>();
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


            response.Data = utente;

            return response;
        }
    }
}
