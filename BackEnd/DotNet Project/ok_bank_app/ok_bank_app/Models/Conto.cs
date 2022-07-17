namespace ok_bank_app.Models
{
    public class Conto
    {

        /*
         * Classe in fase di sviluppo, per ora contiene informazioni base, attendere la fine della creazione del file UML
         */

        public int Id { get; set; }
        public Utente Utente { get; set; }
        public int Saldo { get; set; }
        public string Iban { get; set; }
    }
}
