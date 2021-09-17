using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerfortechAdminLayoutSystem.Controllers
{
    public class ProductController : Controller
    {
        // Ürün Yönetimi
        public ActionResult Index()
        {
            return View();
        }

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

        // Ürün Tanımları

        public ActionResult Supplier()
        {
            return View();
        }
        public ActionResult Categories()
        {
            return View();
        }

        public ActionResult Brands()
        {
            return View();
        }

        // Ürün İşlemleri

        public ActionResult BatchOperations()
        {
            return View();
        }
        public ActionResult BatchPriceOperations()
        {
            return View();
        }

        public ActionResult BatchStockOperations()
        {
            return View();
        }
        public ActionResult ExcelOperations()
        {
            return View();
        }

    }
}