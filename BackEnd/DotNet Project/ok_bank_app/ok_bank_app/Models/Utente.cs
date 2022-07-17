namespace ok_bank_app.Models
{
    public class Utente
    {

        /* Creazione dell'Entity Utente
         * Contiene informazioni generali su ogni utente registrato
         * 
         * Il campo 'Attivo' indica la volonta dell'utente di mantenere il suo Account attivo nella Banca 'OK'
         * 
         * TODO : generazione dell'iban automatica
         *      : togliere i valori e lasciare le variabili vuote una volta collegato il db (per ora serve una versione statica)
         */

        public bool Attivo { get; set; } = true;
        public string iban { get; set; } = "IT99C1234567890123456780001";
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
