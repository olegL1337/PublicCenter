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
        static public PublicContext db;
        public HomeController(PublicContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(LogInModel logInModel)
        {
            var str = logInModel.Login;
            Worker worker = db.Workers.FirstOrDefault(w => w.Mobile_phone == logInModel.Login && w.Passport == logInModel.Password);
            if (worker != null)
            {
                if (worker.Role == "Admin") return RedirectToAction("Start", "Admin", new { id = worker.ID });
                if (worker.Role=="Manager") return RedirectToAction("Start", "Manager", new { id = worker.ID });
                else return RedirectToAction("Start", "Worker", new { id = worker.ID });
            }
                 
            else
            {
                ViewBag.Error = "Invalid login and invalid password";
                return View();
            }
                

        }
        public IActionResult Index()
        {
            //if (!db.Clients.Any()) fillDB();
            return RedirectToAction("LogIn");
        }

        //public void fillDB()
        //{
        //    db.ServiceTypes.Add(new ServiceType { ID = 1, Name = "Helping123" });
        //    db.Services.Add(new Service { GroupOfMotorActivity = "sad", ServiceTypeID = 1, Name = "HELP!", Price = 200, ID = 1 });
        //    db.Workers.Add(new Worker
        //    {
        //        ID = 1,
        //        Age = 22,
        //        Date_birth = DateTime.Now,
        //        Father_name = "dasd",
        //        First_name = "dasd",
        //        Last_name = "dasd",
        //        Sex = true,
        //        Passport = "1111",
        //        Mobile_phone = "1111"
        //    });
        //    db.Addresses.Add(new Address { ID = 1, Addr = "bee", City = "Lviv", District = "hav" });
        //    db.Clients.Add(new Client
        //    {
        //        First_name = "dasd",
        //        Last_name = "dasd",
        //        Father_name = "dasd",
        //        Age = 20,
        //        ID = 1,
        //        Real_addressId = 1,
        //        WorkerID = 1,
        //        Identify_number = "dasddad"
        //    });
        //    db.Schedules.Add(new Schedule { ClientID = 1, Day = DateTime.Today.DayOfWeek.ToString() });
        //    db.ClientTypeOfServices.Add(new ClientTypeOfService { ClientID = 1, ServiceTypeID = 1 });
        //    db.SaveChanges();
        //}

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
