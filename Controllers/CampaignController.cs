using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerfortechAdminLayoutSystem.Controllers
{
    public class CampaignController : Controller
    {
        // E-Ticaret Kampanyaları

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TSoftDiscount()
        {
            return View();
        }
        public ActionResult DevelopOffer()
        {
            return View();
        }

        // Sanal Pos Kampanyaları

        public ActionResult PayTRDiscount()
        {
            return View();
        }
        public ActionResult SipayDiscount()
        {
            return View();
        }

        // Sanal Pos Kampanyaları

        public ActionResult InsiderCampaign()
        {
            return View();
        }
        public ActionResult AdmitadCampaign()
        {
            return View();
        }
    }
}