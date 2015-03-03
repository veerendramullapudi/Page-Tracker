using CustomFilters.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomFilters.Controllers
{
    public class HomeController : Controller
    {
        [TrackAudit]
        public ActionResult Index()
        {
            return View();
        }

    }
}
