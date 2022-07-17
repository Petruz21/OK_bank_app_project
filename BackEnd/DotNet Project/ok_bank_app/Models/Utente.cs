namespace ok_bank_app.Models
{
    public class Utente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Eta {  get; set; }
        public string CodiceFiscale { get; set; }
        public string numeroCI { get; set; }
        public Indirizzo Indirizzo { get; set; }

    }
}
