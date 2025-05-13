using MvcTrainingHub.Business.Concrete;
using MvcTrainingHub.Business.ValidationRules;
using MvcTrainingHub.DataAccess.EntityFramework;
using MvcTrainingHub.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;

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
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                categoryManager.CategoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in results.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return RedirectToAction("Index");
        }
    }
}