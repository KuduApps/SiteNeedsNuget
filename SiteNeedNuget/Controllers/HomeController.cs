using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.IO;

namespace SiteNeedNuget.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Newtonsoft.Json.JsonSerializer ser = new Newtonsoft.Json.JsonSerializer();

            string json = JsonConvert.SerializeObject(new Foo { Bar = "a"});

            ViewBag.Message = "Welcome to ASP.NET MVC!" + json;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }


    }
    public class Foo
    {
        public string Bar { get; set; }
    }
}
