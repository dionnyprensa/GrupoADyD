namespace GrupoADyD.Domain.Entities
{
    public class DetailAccountsReceivable
    {
        public int Id { get; set; }
        public int AccountsReceivableId { get; set; }
        public decimal Due { get; set; }
        public decimal Paid { get; set; }

        public virtual AccountsReceivable AccountsReceivable { get; set; }
    }
}