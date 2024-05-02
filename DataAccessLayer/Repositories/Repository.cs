using DataAccessLayer.Context;
using DataAccessLayer.Interfaces.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        internal readonly EstacionamentoContext _context;

        public Repository(EstacionamentoContext context)
        {
            _context = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }
        public virtual T GetById(int id)
        {
            return _context.Set<T>().Where(where => where.Id == id).FirstOrDefault();
        }

        public virtual T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public virtual T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return entity;
        }

        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            _context.Set<T>().Remove(entity);
        }

        public virtual T FirstOrDefault()
        {
            return _context.Set<T>().FirstOrDefault();
        }
    }
}
