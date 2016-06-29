using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}