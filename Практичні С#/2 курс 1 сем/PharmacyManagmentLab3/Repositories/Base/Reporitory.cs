using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Reporitories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PharmacyContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(PharmacyContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges(); 
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
