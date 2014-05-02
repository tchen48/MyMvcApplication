using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewData["Contries"]=  new List<string>()
            {
                "Indix",
                "US",
                "China"
            };

            return View();
        }
        

    }
}
