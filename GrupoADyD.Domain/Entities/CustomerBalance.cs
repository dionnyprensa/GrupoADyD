namespace GrupoADyD.Domain.Entities
{
    public class CustomerBalance
    {
        public int Id { get; set; }
        public virtual Client Client { get; set; }
        public decimal Amount { get; set; }
    }
}