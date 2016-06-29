using GrupoADyD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using GrupoADyD.Domain.Interfaces;

namespace GrupoADyD.Infrastructure.Repositories
{
    public class AccessRepository : IRepository<Access>
    {
        private readonly ApplicationDbContext _context;
        //private ApplicationRoleManager _roleManager;
        //private ApplicationUserManager _userManager;

        //public AccessRepository(ApplicationDbContext db)
        //{
        //    _db = db;
        //    _roleManager = new ApplicationRoleManager(new ApplicationRoleStore(db));
        //    _userManager = new ApplicationUserManager(new ApplicationUserStore(db));
        //}

        public AccessRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Access> GetAll
        {
            get
            {
                return _context.Access.ToList();
            }
        }

        public Access Get(Access entity)
        {
            return _context.Access.Find(entity);
        }

        public Access GetById(int Id)
        {
            return (from a in GetAll where a.Id == Id select a).FirstOrDefault();
        }

        public void Create(Access entity)
        {
            _context.Access.Add(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Update(Access entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(Access entity)
        {
            _context.Access.Remove(entity);
        }
    }
}
