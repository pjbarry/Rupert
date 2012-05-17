using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rupert.Controllers
{
    public class RupertController : Controller
    {
        //
        // GET: /Rupert/

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Config()
        {
            return View();
        }

        public ActionResult Network()
        {
            return View();
        }
    }
}
