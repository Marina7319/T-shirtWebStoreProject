using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using T_shirtWebStore.Data.Data;
using T_shirtWebStore.Data.Repository.IRepository;

namespace T_shirtWebStore.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext database;
        internal DbSet<T> db;

        public Repository(ApplicationDbContext _database)
        {
            database= _database;
            this.db = database.Set<T>();


        }
        public void Add(T entity)
        {
            db.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = db;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = db;
            return query.ToList();
        }

        public void Remove(T entity)
        {
            db.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            db.RemoveRange(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
    
}
