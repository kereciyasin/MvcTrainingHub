using MvcTrainingHub.DataAccess.Concrete.Repositories;
using MvcTrainingHub.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcTrainingHub.Business.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repository.GetAll();
        }

        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
            {
                // error message
            }
            else
            {
                repository.Insert(p);
            }
        }
    }
}
