using SeleniumMvc.Models.ORM.Context;
using SeleniumMvc.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeleniumMvc.Controllers
{
    public class ProductController : Controller
    {
        ProjectContext db = new ProjectContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult Add(Product data)
        {
            db.Products.Add(data);
            db.SaveChanges();
            return Redirect("~/Home/Index");
        }
    }
}