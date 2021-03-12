using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HairSalon.Controllers
{
    public class HomeController : Controller 
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}