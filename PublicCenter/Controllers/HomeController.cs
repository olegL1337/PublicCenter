using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PublicCenter.DAL;
using PublicCenter.Models;
using PublicCenter.Models.ExtraModels;

namespace PublicCenter.Controllers
{
    public class HomeController : Controller
    {
        public PublicContext db;
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(LogInModel logIn)
        {
            Worker worker = db.Workers.FirstOrDefault(w => w.Mobile_phone == logIn.Login && w.Passport == logIn.Password);
            if (worker != null) return RedirectToAction("Index", "Worker", worker.ID);
            else return View();

        }
        public IActionResult Index()
        {
            return RedirectToAction("LogIn");
        }
       public void fillDB()
        {
            db.ServiceTypes.AddRange{ new ser}
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
