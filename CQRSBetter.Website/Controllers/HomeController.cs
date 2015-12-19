using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CQRSBetter.Website.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            return View(Views.Index);
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return RedirectToAction(Actions.Index());
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(Views.Contact);
        }
    }
}