using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AttributeRouting.Web.Mvc;

namespace MVCWEB.Controllers
{
    public class HomeController : Controller
    {
        [GET("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
