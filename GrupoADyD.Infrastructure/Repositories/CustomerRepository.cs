using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GrupoADyD.Infrastructure.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll
        {
            get
            {
                return _context.Clients.ToList();
            }
        }

        public Customer Get(Customer entity)
        {
            return _context.Clients.Find(entity);
        }

        public Customer GetById(int Id)
        {
            return (from a in GetAll where a.Id == Id select a).FirstOrDefault();
        }

        public void Create(Customer entity)
        {
            _context.Clients.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Customer entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(Customer entity)
        {
            _context.Clients.Remove(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}