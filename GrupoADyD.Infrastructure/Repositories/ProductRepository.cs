using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GrupoADyD.Infrastructure.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll
        {
            get
            {
                return _context.Products.ToList();
            }
        }

        public Product Get(Product entity)
        {
            return _context.Products.Find(entity);
        }

        public Product GetById(int Id)
        {
            return (from a in GetAll where a.Id == Id select a).FirstOrDefault();
        }

        public void Create(Product entity)
        {
            _context.Products.Add(entity);
        }

        public void Update(Product entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(Product entity)
        {
            _context.Products.Remove(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}