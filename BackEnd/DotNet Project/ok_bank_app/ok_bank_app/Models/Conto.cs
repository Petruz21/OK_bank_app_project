namespace ok_bank_app.Models
{
    public class Conto
    {
        public int Id { get; set; }
        public Utente Utente { get; set; }
        public int Saldo { get; set; }
        public string Iban { get; set; }
    }
}
