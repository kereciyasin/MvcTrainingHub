using MvcTrainingHub.Business.Concrete;
using MvcTrainingHub.Business.ValidationRules;
using MvcTrainingHub.DataAccess.EntityFramework;
using MvcTrainingHub.Entities.Concrete;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;

namespace MvcTrainingHub.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        // GET: Admin
        public ActionResult Index()
        {
            var categoryList = categoryManager.GetList();
            return View(categoryList);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p);
            CategoryValidator categoryValidator = new CategoryValidator();
            FluentValidation.Results.ValidationResult result = categoryValidator.Validate(p);
            if (result.IsValid)
            {
                categoryManager.CategoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}