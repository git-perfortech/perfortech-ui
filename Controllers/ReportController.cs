using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerfortechAdminLayoutSystem.Controllers
{
    public class ReportController : Controller
    {
        // Ürün Raporu

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductReport()
        {
            return View();
        }
        public ActionResult WeeklyTopSeller()
        {
            return View();
        }
        public ActionResult MonthlyTopSeller()
        {
            return View();
        }
        public ActionResult YearlyTopSeller()
        {
            return View();
        }

        // Sipariş Raporu

        public ActionResult OrderReport()
        {
            return View();
        }
        public ActionResult WeeklySellerReport()
        {
            return View();
        }
        public ActionResult MonthlySellerReport()
        {
            return View();
        }
        public ActionResult YearlySellerReport()
        {
            return View();
        }

        // Stok Raporu

        public ActionResult LowStockReport()
        {
            return View();
        }
        public ActionResult MonthlyStockReport()
        {
            return View();
        }
        public ActionResult MontlySellerReport()
        {
            return View();
        }

    }
}