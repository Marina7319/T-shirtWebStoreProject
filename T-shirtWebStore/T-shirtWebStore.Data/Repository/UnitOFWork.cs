using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_shirtWebStore.Data.Data;
using T_shirtWebStore.Data.Repository.IRepository;

namespace T_shirtWebStore.Data.Repository
{
    public class UnitOFWork : IUnitOfWork
    {
        private ApplicationDbContext applicationDbContext;
        public UnitOFWork(ApplicationDbContext _applicationDbContext) 
        {
            applicationDbContext = _applicationDbContext;
            CategoryRepository = new CategoryRepository(_applicationDbContext);
        }
        public ICategoryRepository CategoryRepository { get; private set; }

        public void Save()
        {
            applicationDbContext.SaveChanges();
        }
    }
}
