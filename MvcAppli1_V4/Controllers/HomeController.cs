using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAppli1_V4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Countries= new List<string>()
            {
                "India",
                "USA",
                "Switzerland",
                "UK"
            };
            return View();
        }


        //public string Index1(string name,int id)
        //{
        //    return "Id is: "+id+" Name is: "+name;
        //}
    }
}
