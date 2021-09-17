using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerfortechAdminLayoutSystem.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult List()
        {
            return View();
        }
        public ActionResult SubProduct()
        {
            return View();
        }

        public ActionResult Attribute()
        {
            return View();
        }
        

    }
}