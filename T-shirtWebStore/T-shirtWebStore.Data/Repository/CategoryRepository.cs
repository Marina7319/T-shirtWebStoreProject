using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using T_shirtWebStore.Data.Data;
using T_shirtWebStore.Data.Repository.IRepository;
using T_shirtWebStore.Models;

namespace T_shirtWebStore.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        private ApplicationDbContext _database;
        public CategoryRepository(ApplicationDbContext database) : base(database)
        {
            _database = database;
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Category entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Category> entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _database.SaveChanges();
        }

        public void Update(Category category)
        {
            _database.Categories.Update(category);
        }
    }
}
