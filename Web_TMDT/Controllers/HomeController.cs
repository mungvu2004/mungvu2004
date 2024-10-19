using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_TMDT.Models;

namespace Web_TMDT.Controllers
{
    //[Route("Home/Index/")]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //List<Container> containers = new Container()
            //{
            //    new {Id = 1, }
            //}
            return View();
            
        }
        
    }
}