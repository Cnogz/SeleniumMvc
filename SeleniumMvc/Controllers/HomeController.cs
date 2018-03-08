using SeleniumMvc.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeleniumMvc.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();

        public ActionResult Index()
        {
            var ProductList = db.Products.ToList();
            return View(ProductList);
        }
    }
}