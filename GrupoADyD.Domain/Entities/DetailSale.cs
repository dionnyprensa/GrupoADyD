namespace GrupoADyD.Domain.Entities
{
    public class DetailSale
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public bool ToCreditNote { get; set; }

        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int CreditNoteId { get; set; }

        public virtual Sale Sale { get; set; }
        public virtual Product Product { get; set; }
        public virtual CreditNote CreditNote { get; set; }
    }
}