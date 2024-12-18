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
        private readonly IUnitOfWork _unitOfWork;

        private ApplicationDbContext _app;
        public CategoryRepository(ApplicationDbContext app) : base(app)
        {
            _app = app;
        }

   
        public void Update(Category category)
        {
            _app.Categories.Update(category);
        }
    }
}
