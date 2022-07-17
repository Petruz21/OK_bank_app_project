namespace ok_bank_app.Models
{
    public class Utente
    {
        public static Indirizzo IndirizzoUtente = new Indirizzo
        {
            Paese = "Italia",
            Regione = "Piemonte",
            Provincia = "Torino",
            Comune = "Torino",
            Via = "Porpora",
            NumeroCivico = "55",
            Cap = "10154"
        };

        public int Id { get; set; } = 0;
        public string Nome { get; set; } = "Emanuel";
        public string Cognome { get; set; } = "Petrut";
        public string Eta { get; set; } = "21";
        public string CodiceFiscale { get; set; } = "PTRMLN01B24Z129Q";
        public string numeroCI { get; set; } = "IA546IE";
        public string Paese { get; set; } = "Italia";
        public string Regione { get; set; } = "Piemonte";
        public string Provincia { get; set; } = "Torino";
        public string Comune { get; set; } = "Torino";
        public string Via { get; set; } = "Porpora";
        public string NumeroCivico { get; set; } = "55";
        public string Cap { get; set; } = "10154";


    }
}
