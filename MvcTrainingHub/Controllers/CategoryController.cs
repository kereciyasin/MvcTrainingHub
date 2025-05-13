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




namespace MvcTrainingHub.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        // GET: Category
        public ActionResult GetCategoryList()
        {
            //var value = cm.GetAllBL();
            return View();
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
            return RedirectToAction("GetCategoryList");
        }
    }
}