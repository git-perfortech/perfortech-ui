using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerfortechAdminLayoutSystem.Controllers
{
    public class RequestController : Controller
    {
        // Destek Talepleri
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RequestCreate()
        {
            return View();
        }
        public ActionResult Requests()
        {
            return View();
        }
        public ActionResult EducationMeetingCreate()
        {
            return View();
        }
        public ActionResult EducationVideosCenter()
        {
            return View();
        }

        // Geliştirme Talepleri

        public ActionResult CustomIntegrationRequest()
        {
            return View();
        }
        public ActionResult AutomationSoftwareRequest()
        {
            return View();
        }
        public ActionResult ECommerceDesignRequest()
        {
            return View();
        }
        public ActionResult ECommerceConsultancyRequest()
        {
            return View();
        }

        // Güncelleme Notları

        public ActionResult WeeklyUpdateNotes()
        {
            return View();
        }
        public ActionResult MarketplaceUpdateNotes()
        {
            return View();
        }
        public ActionResult NewIntegration()
        {
            return View();
        }
        public ActionResult HelpCenter()
        {
            return View();
        }
    }
}