using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GrupoADyD.Infrastructure.Repositories
{
    public class SaleRepository : IRepository<Sale>
    {
        private ApplicationDbContext _context;

        public SaleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Sale> GetAll
        {
            get
            {
                return _context.Sales.ToList();
            }
        }

        public Sale Get(Sale entity)
        {
            return _context.Sales.Find(entity);
        }

        public Sale GetById(int Id)
        {
            return (from a in GetAll where a.Id == Id select a).FirstOrDefault();
        }

        public void Create(Sale entity)
        {
            _context.Sales.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Sale entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(Sale entity)
        {
            _context.Sales.Remove(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}