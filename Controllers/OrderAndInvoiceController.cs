using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerfortechAdminLayoutSystem.Controllers
{
    public class OrderAndInvoiceController : Controller
    {
        // Ürün
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ApprovedOrder()
        {
            return View();
        }
        public ActionResult OrderList()
        {
            return View();
        }
        public ActionResult OrderSettings()
        {
            return View();
        }
        public ActionResult OrderCreate()
        {
            return View();
        }
        
        // Fatura

        public ActionResult InvoiceList()
        {
            return View();
        }
        public ActionResult ClassicInvoiceSettings()
        {
            return View();
        }
        public ActionResult EInvoiceSettings()
        {
            return View();
        }
        public ActionResult InvoiceCreate()
        {
            return View();
        }

        // Cari Hesap

        public ActionResult CurrentAccountList()
        {
            return View();
        }
        public ActionResult CurrentAccountSettings()
        {
            return View();
        }
        public ActionResult CurrentAccountCreate()
        {
            return View();
        }
    }
}