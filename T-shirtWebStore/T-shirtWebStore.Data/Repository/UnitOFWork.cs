using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_shirtWebStore.Data.Data;
using T_shirtWebStore.Data.Repository.IRepository;

namespace T_shirtWebStore.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext applicationDbContext;
        public ICategoryRepository Category { get; private set; }
        public UnitOfWork(ApplicationDbContext _applicationDbContext) 
        {
            applicationDbContext = _applicationDbContext;
            Category = new CategoryRepository(applicationDbContext);
        }

        public void Save()
        {
            applicationDbContext.SaveChanges();
        }
    }
}
