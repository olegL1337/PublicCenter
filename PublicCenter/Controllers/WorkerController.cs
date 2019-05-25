using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PublicCenter.DAL;
using PublicCenter.Models;
using PublicCenter.Models.ExtraModels;

namespace PublicCenter.Controllers
{
    public class WorkerController : Controller
    {
        public PublicContext db;
        Worker currentWorker;
        // GET: Worker
        public IActionResult Index(int id)
        {
            currentWorker = db.Workers.FirstOrDefault(w => w.ID == id);
            return View();
        }
        public IActionResult ClientList()
        {
            
            return View(db.Clients.Where(c=>c.WorkerID==currentWorker.ID));
        }

        public IActionResult Schedule()
        {
            //var todayList;
            List<Client> todayClients = new List<Client>();
            foreach (Client c in db.Clients.Where(c => c.WorkerID == currentWorker.ID))
            {
                if (db.Schedules.Where(s => s.ClientID == c.ID && s.Day == DateTime.Today.DayOfWeek.ToString()).Any())
                {
                    todayClients.Add(c);
                }
            }
            var model = new List<ScheduleModel>();
            foreach(Client c in todayClients)
            {
                foreach (ClientTypeOfService s in db.ClientTypeOfServices.Where(ts => ts.ClientID == c.ID))
                {
                    model.Add(new ScheduleModel { client = c, service = db.Services.FirstOrDefault(serv=>serv.ID==s.ServiceID)});
                }
            }
            return View();
        }
        // GET: Worker/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Worker/Create
        public ActionResult Create()
        {
            foreach (Client c in db.Clients.Where(c => c.WorkerID == currentWorker.ID))
            {
                if (db.Schedules.Where(s => s.ClientID == c.ID && s.Day == DateTime.Today.DayOfWeek.ToString()).Any())
                {

                }
            }
            return View();
        }

        // POST: Worker/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Worker/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Worker/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Worker/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Worker/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}