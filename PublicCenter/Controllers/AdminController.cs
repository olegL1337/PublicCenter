using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL;
using PublicCenter.Models;
using PublicCenter.Models.ExtraModels;

namespace PublicCenter.Controllers
{
    public class AdminController : Controller
    {
        static public PublicContext db;
        static public Worker currentAdmin;
        public IActionResult Start(int id)
        {
            db = new PublicContext();
            currentAdmin = db.Workers.FirstOrDefault(w => w.ID == id);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View(currentAdmin);
        }
        [HttpGet]
        public IActionResult ClientList()
        {
            ViewBag.Departaments = db.Departments.ToList();

            var clientsModel = new List<ClientListModel>();
            foreach (Client client in db.Clients)
            {
                clientsModel.Add(new ClientListModel
                {
                    Сlient = client,
                    Department = db.Departments.FirstOrDefault(d => d.ID == client.DepartmentID),
                    RealAddress = db.Addresses.FirstOrDefault(a => a.ID == client.Real_addressId),
                    FormalAddress = db.Addresses.FirstOrDefault(a => a.ID == client.Formal_addressId),
                    Worker = db.Workers.FirstOrDefault(w => w.ID == client.WorkerID)
                });
            }
            return View(clientsModel);
        }
        [HttpPost]
        public IActionResult ClientList(int? depId)
        {
            ViewBag.Departaments = db.Departments.ToList();
            if (depId == null) return RedirectToAction("ClientList");

            var clientsModel = new List<ClientListModel>();
            foreach (Client client in db.Clients.Where(c => c.DepartmentID == depId))
            {
                clientsModel.Add(new ClientListModel
                {
                    Сlient = client,
                    Department = db.Departments.FirstOrDefault(d => d.ID == client.DepartmentID),
                    RealAddress = db.Addresses.FirstOrDefault(a => a.ID == client.Real_addressId),
                    FormalAddress = db.Addresses.FirstOrDefault(a => a.ID == client.Formal_addressId),
                    Worker = db.Workers.FirstOrDefault(w => w.ID == client.WorkerID)
                });
            }
            return View(clientsModel);
        }
        [HttpGet]
        public IActionResult WorkerList()
        {
            ViewBag.Departaments = db.Departments;
            var workerList = new List<Worker>();
            foreach (Worker worker in db.Workers)
            {
                worker.Address = db.Addresses.FirstOrDefault(a => a.ID == worker.AddressID);
                workerList.Add(worker);
            }
            return View(workerList);
        }
        [HttpPost]
        public IActionResult WorkerList(int? depId)
        {
            if (depId == null) return RedirectToAction("WorkerList");
            ViewBag.Departaments = db.Departments.ToList();

            var workerList = new List<Worker>();
            foreach (Worker worker in db.Workers.Where(w => w.DepartmentID == depId))
            {
                worker.Address = db.Addresses.FirstOrDefault(a => a.ID == worker.AddressID);
                workerList.Add(worker);
            }
            return View(workerList);
        }
        public IActionResult ServiceList()
        {
            return View(new ServiceListModel { services = db.Services.ToList(), servicesTypes = db.ServiceTypes.ToList() });
        }
        [HttpGet]
        public IActionResult Statistics()
        {
            ViewBag.Departaments = db.Departments;
            List<DoneWork> dones = new List<DoneWork>();
            foreach (DoneWork work in db.DoneWorks)
            {
                //if (db.Workers.FirstOrDefault(w => w.ID == work.WorkerID).DepartmentID == currentManager.DepartmentID)
                //{
                    dones.Add(new DoneWork
                    {
                        Client = db.Clients.FirstOrDefault(c => c.ID == work.ClientID),
                        Worker = db.Workers.FirstOrDefault(w => w.ID == work.WorkerID),
                        Service = db.Services.FirstOrDefault(s => s.ID == work.ServiceID),
                        Date_of_service = work.Date_of_service,
                        ID = work.ID
                    });
                //}

            }
            return View(dones);
        }
        [HttpPost]
        public IActionResult Statistics(int? depId)
        {
            if (depId == null) return RedirectToAction("Statistics");
            ViewBag.Departaments = db.Departments;
            List<DoneWork> dones = new List<DoneWork>();
            foreach (DoneWork work in db.DoneWorks)
            {
                if (db.Workers.FirstOrDefault(w => w.ID == work.WorkerID).DepartmentID == depId)
                {
                    dones.Add(new DoneWork
                    {
                        Client = db.Clients.FirstOrDefault(c => c.ID == work.ClientID),
                        Worker = db.Workers.FirstOrDefault(w => w.ID == work.WorkerID),
                        Service = db.Services.FirstOrDefault(s => s.ID == work.ServiceID),
                        Date_of_service = work.Date_of_service,
                        ID = work.ID
                    });
                }

            }
            return View(dones);
        }
        [HttpGet]
        public IActionResult CreateService()
        {
            ViewBag.Types = db.ServiceTypes;
            return View();
        }
        [HttpPost]
        public IActionResult CreateService(Service service, int? typeId)
        {
            service.ID = db.Services.Count() + 1;
            service.ServiceTypeID = typeId;
            db.Services.Add(service);
            db.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public IActionResult CreateServiceType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateServiceType(ServiceType serviceType)
        {
            serviceType.ID= db.ServiceTypes.Count() + 1;
            db.ServiceTypes.Add(serviceType);
            db.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public IActionResult EditService(int? id)
        {
            Service service = db.Services.FirstOrDefault(s => s.ID == id);
            ViewBag.Types = db.ServiceTypes.Where(t=>t.ID!=service.ServiceTypeID);
            return View(service);
        }
        [HttpPost]
        public async Task<IActionResult> EditService(Service service, int? typeId)
        {
            service.ServiceTypeID = typeId;
            db.Entry(db.Services.FirstOrDefault(s => s.ID == service.ID)).State = EntityState.Detached;

            db.Entry(service).State = EntityState.Modified;
            db.Services.Update(service);
            await db.SaveChangesAsync();
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public IActionResult EditServiceType(int? id)
        {
            return View(db.ServiceTypes.FirstOrDefault(t=>t.ID==id));
        }
        [HttpPost]
        public async Task<IActionResult> EditServiceType(ServiceType serviceType)
        {
            db.Entry(db.ServiceTypes.FirstOrDefault(s => s.ID == serviceType.ID)).State = EntityState.Detached;

            db.Entry(serviceType).State = EntityState.Modified;
            db.ServiceTypes.Update(serviceType);
            await db.SaveChangesAsync();
            return RedirectToAction("ServiceList");
        }
    }
}