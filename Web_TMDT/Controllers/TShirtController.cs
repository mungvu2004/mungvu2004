using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_TMDT.Models;

namespace Web_TMDT.Controllers
{
    public class TShirtController : Controller
    {
        // GET: TShirt
        public ActionResult Index()
        {
            Database1Entities db = new Database1Entities();
            List<TShirt> tshirt =  db.TShirts.ToList();
            return View(tshirt);
        }
    }
}