using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkFlowSystemConsoler.PController;

namespace WorkFlowSystemConsoler.Controllers
{
    public class HomeController : IdentityController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}