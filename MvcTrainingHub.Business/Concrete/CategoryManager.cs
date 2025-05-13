using MvcTrainingHub.Business.Abstract;
using MvcTrainingHub.DataAccess.Abstract;
using MvcTrainingHub.DataAccess.Concrete.Repositories;
using MvcTrainingHub.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcTrainingHub.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetAll();
        }
    }
}
