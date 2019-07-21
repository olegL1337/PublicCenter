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
    public class ManagerController : Controller
    {
        static public PublicContext db;
        static public Worker currentManager;
        static public List<ClientListModel> clientsModel;
        public IActionResult Start(int id)
        {
            db = new PublicContext();
            currentManager = db.Workers.FirstOrDefault(w => w.ID == id);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {

            return View(currentManager);
        }
        public IActionResult ClientList()
        {
            clientsModel = new List<ClientListModel>();
            foreach (Client client in db.Clients.Where(c => c.DepartmentID == currentManager.DepartmentID))
            {
                clientsModel.Add(new ClientListModel
                {
                    Сlient = client,
                    Department = db.Departments.FirstOrDefault(d => d.ID == currentManager.ID),
                    RealAddress = db.Addresses.FirstOrDefault(a => a.ID == client.Real_addressId),
                    FormalAddress = db.Addresses.FirstOrDefault(a => a.ID == client.Formal_addressId),
                    Worker = db.Workers.FirstOrDefault(w => w.ID == client.WorkerID)   
                });
            }
            return View(clientsModel);
        }
        public IActionResult WorkerList()
        {
            var workerList = new List<Worker>();
            foreach(Worker worker in db.Workers.Where(w=>w.DepartmentID== currentManager.DepartmentID))
            {
                worker.Address = db.Addresses.FirstOrDefault(a => a.ID == worker.AddressID);
                workerList.Add(worker);
            }
            return View(workerList);
        }
        public IActionResult ServiceList()
        {
            return View(new ServiceListModel {services=db.Services.ToList(), servicesTypes=db.ServiceTypes.ToList() });
        }
        public IActionResult DepStatistics()
        {
            List<DoneWork> dones = new List<DoneWork>();
            foreach(DoneWork work in db.DoneWorks)
            {
                if (db.Workers.FirstOrDefault(w=> w.ID==work.WorkerID).DepartmentID == currentManager.DepartmentID)
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
        public IActionResult CreateWorker()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateWorker(Worker worker)
        {
            worker.Address.ID = db.Addresses.Count() + 1;
            db.Addresses.Add(worker.Address);
            worker.ID = db.Workers.Count() + 1;
            worker.Role = "Worker";
            worker.DepartmentID = currentManager.DepartmentID;

            db.Workers.Add(worker);
            db.SaveChanges();
            return RedirectToAction("WorkerList");
        }
        [HttpGet]
        public IActionResult CreateClient()
        {
            ViewBag.ServiceTypes = db.ServiceTypes.ToList();
            ViewBag.Workers = db.Workers.Where(w => w.DepartmentID == currentManager.DepartmentID);
            return View();
        }
       [HttpPost]
       public IActionResult CreateClient(Client client, List<string> schedule, List<int> services, int worker)
        {
            client.ID = db.Clients.Count() + 1;
            client.DepartmentID = currentManager.DepartmentID;
            client.Formal_address.ID= db.Addresses.Count() + 1;
            client.Real_address.ID = db.Addresses.Count() +2;
            client.Worker = db.Workers.FirstOrDefault(w => w.ID == worker);
            foreach(string s in schedule)
            {
                db.Schedules.Add(new Schedule { ClientID = client.ID, Day = s });
            }
            db.Clients.Add(client);
            db.SaveChanges();
            return RedirectToAction("ClientList");
        }

        [HttpGet]
        public IActionResult EditClient(int? id)
        {
            ViewBag.Week = new WeekModel(db.Schedules.Where(s => s.ClientID == id).ToList());
            ViewBag.ServiceTypes = db.ServiceTypes.ToList();
            Client client = db.Clients.FirstOrDefault(c => c.ID == id);
            client.Worker = db.Workers.FirstOrDefault(w=>w.ID==client.WorkerID);
            ViewBag.Workers = db.Workers.Where(w => w.DepartmentID == currentManager.DepartmentID&&client.WorkerID!=w.ID);

            return View(client);
        }
        [HttpPost]
        public async Task<IActionResult> EditClient(Client client, List<string> schedule, List<int> services, int worker)
        {
            db.Schedules.RemoveRange(db.Schedules.Where(s=>s.ClientID==client.ID));
            db.Entry(db.Addresses.FirstOrDefault(a => client.Formal_addressId == a.ID)).State = EntityState.Detached;
            db.Entry(db.Addresses.FirstOrDefault(a => client.Real_addressId == a.ID)).State = EntityState.Detached;
            client.Formal_address.ID = (int)client.Formal_addressId;
            client.Real_address.ID = (int)client.Real_addressId;


            db.Entry(client.Formal_address).State = EntityState.Modified;
            db.Addresses.Update(client.Formal_address);
            db.Entry(db.Addresses.FirstOrDefault(a => client.Real_addressId == a.ID)).State = EntityState.Detached;


            db.Entry(client.Real_address).State = EntityState.Modified;
            db.Addresses.Update(client.Real_address);

            await db.SaveChangesAsync();
            foreach (string s in schedule)
            {
                db.Schedules.Add(new Schedule { ClientID = client.ID, Day = s });
            }
            client.Worker = db.Workers.FirstOrDefault(w => w.ID == worker);
            db.Entry(db.Clients.FirstOrDefault(c => client.ID == c.ID)).State = EntityState.Detached;
            db.Entry(client).State = EntityState.Modified;
            db.Clients.Update(client);
            await db.SaveChangesAsync();
            return RedirectToAction("ClientList");
        }
        [HttpGet]
        public IActionResult EditWorker(int? id)
        {

            return View(db.Workers.FirstOrDefault(w => w.ID == id));
        }
        [HttpPost]
        public async Task<IActionResult> EditWorker(Worker worker)
        {
            db.Entry(db.Addresses.FirstOrDefault(a => worker.AddressID == a.ID)).State = EntityState.Detached;
            worker.Address.ID = (int)worker.AddressID;
            db.Entry(worker.Address).State = EntityState.Modified;
            db.Addresses.Update(worker.Address);

            db.Entry(db.Workers.FirstOrDefault(w => worker.ID == w.ID)).State = EntityState.Detached;
            db.Entry(worker).State = EntityState.Modified;
            db.Workers.Update(worker);

            await db.SaveChangesAsync();
            return RedirectToAction("WorkerList");
        }
        public IActionResult DetailsClient(int? id)
        {
            var client = db.Clients.FirstOrDefault(c => c.ID == id);
            ViewBag.Week = new WeekModel(db.Schedules.Where(s => s.ClientID == id).ToList());
            var typesList = new List<ServiceType>();
            foreach(ClientTypeOfService types in db.ClientTypeOfServices.Where(t=>t.ClientID==client.ID))
            {
                typesList.Add(db.ServiceTypes.FirstOrDefault(t => t.ID == types.ServiceTypeID));
            }
            ViewBag.Types = typesList;
            return View(client);
        }
    }
}