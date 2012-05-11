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

        public ActionResult home()
        {
            return View();
        }

        public ActionResult config()
        {
            return View();
        }
    }
}
