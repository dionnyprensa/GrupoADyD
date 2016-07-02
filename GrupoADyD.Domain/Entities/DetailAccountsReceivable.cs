namespace GrupoADyD.Domain.Entities
{
    public class DetailAccountsReceivable
    {
        public int Id { get; set; }
        public AccountsReceivable AccountsReceivable { get; set; }
        public decimal Due { get; set; }
        public decimal Paid { get; set; }
    }
}