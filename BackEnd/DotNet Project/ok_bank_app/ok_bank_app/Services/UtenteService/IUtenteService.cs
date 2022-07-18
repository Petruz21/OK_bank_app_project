using ok_bank_app.Models;
using ok_bank_app.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ok_bank_app.Services.UtenteService
{
    public interface IUtenteService
    {

        public Task<Response<List<Utente>>> GetAllUtenti();
        public Task<Response<Utente>> AddUtente(Utente newUtente);
        public Task<Response<Utente>> DeleteUtente(string iban);
        public Task<Response<Utente>> UpdateUtente(Utente updateUtente);


    }
}
