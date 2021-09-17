using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerfortechAdminLayoutSystem.Controllers
{
    public class SettingsController : Controller
    {
        // Genel Ayarlar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminDashboardSettings()
        {
            return View();
        }
        public ActionResult UserInformation()
        {
            return View();
        }
        public ActionResult NotificationSettings()
        {
            return View();
        }
        public ActionResult PackageInformation()
        {
            return View();
        }

        // Bildirim Ayarları

        public ActionResult ScannerNotification()
        {
            return View();
        }
        public ActionResult SMSNotification()
        {
            return View();
        }
        public ActionResult MailNotification()
        {
            return View();
        }
        public ActionResult StockNotification()
        {
            return View();
        }

        // Log Yönetimi

        public ActionResult ProductsLog()
        {
            return View();
        }
        public ActionResult OrdersLog()
        {
            return View();
        }
        public ActionResult CargosLog()
        {
            return View();
        }
        public ActionResult AllLogs()
        {
            return View();
        }

        // Paket Bilgileri

        public ActionResult ActivePackages()
        {
            return View();
        }
        public ActionResult ContractAndInvoice()
        {
            return View();
        }
        public ActionResult AuthorizedPerson()
        {
            return View();
        }

        // Tasarım Ayarları

        public ActionResult CargoLabel()
        {
            return View();
        }
        public ActionResult InvoiceDesign()
        {
            return View();
        }
        public ActionResult ProductPageDesign()
        {
            return View();
        }

        //Kullanıcı Ayarları
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult UsersAreaLevel()
        {
            return View();
        }
        public ActionResult UsersGroup()
        {
            return View();
        }
        public ActionResult UsersLogs()
        {
            return View();
        }

    }
}