using MvcTrainingHub.Business.Concrete;
using MvcTrainingHub.DataAccess.Abstract;
using MvcTrainingHub.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTrainingHub.DataAccess.Concrete.Repositories;
using MvcTrainingHub.DataAccess.EntityFramework;
using MvcTrainingHub.Business.ValidationRules;
using FluentValidation.Results;




namespace MvcTrainingHub.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        // GET: Category
        public ActionResult GetCategoryList()
        {
            var value = cm.GetList();
            return View(value);
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
            ValidationResult result = categoryValidator.Validate(p);
            if (result.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
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