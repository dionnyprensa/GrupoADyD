using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GrupoADyD.Infrastructure.Repositories
{
    public class ClientRepository : IRepository<Client>
    {
        private ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetAll
        {
            get
            {
                return _context.Clients.ToList();
            }
        }

        public Client Get(Client entity)
        {
            return _context.Clients.Find(entity);
        }

        public Client GetById(int Id)
        {
            return (from a in GetAll where a.Id == Id select a).FirstOrDefault();
        }

        public void Create(Client entity)
        {
            _context.Clients.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Client entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(Client entity)
        {
            _context.Clients.Remove(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}