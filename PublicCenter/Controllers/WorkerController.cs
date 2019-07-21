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
        static public PublicContext db;
        static public Worker currentWorker;
        static public List<ScheduleModel> sheduleModels;
        // GET: Worker
        public IActionResult Start(int id)
        {
            db = new PublicContext();
            currentWorker = db.Workers.FirstOrDefault(w => w.ID == id);

            List<Client> todayClients = new List<Client>();
            foreach (Client c in db.Clients.Where(c => c.WorkerID == currentWorker.ID))
            {
                if (db.Schedules.Where(s => s.ClientID == c.ID && s.Day == DateTime.Today.DayOfWeek.ToString()).Any())
                {
                    todayClients.Add(c);
                }
            }
            sheduleModels = new List<ScheduleModel>();
            foreach (Client c in todayClients)
            {
                foreach (ClientTypeOfService types in db.ClientTypeOfServices.Where(ts => ts.ClientID == c.ID))
                {
                    foreach(Service serv in db.Services.Where(s=>s.ServiceTypeID==types.ServiceTypeID))
                    {
                        sheduleModels.Add(new ScheduleModel
                        {
                            id = sheduleModels.Count + 1,
                            client = c,
                            address = db.Addresses.FirstOrDefault(a => a.ID == c.Real_addressId),
                            service = serv,
                            serviceType = db.ServiceTypes.FirstOrDefault(type => type.ID == types.ServiceTypeID)
                        });
                    }
                    
                }
            }
   
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            
            return View(currentWorker);
        }

        public IActionResult ClientList()
        {
            var clientsModel = new List<ClientListModel>();
            foreach (Client client in db.Clients.Where(c => c.WorkerID==currentWorker.ID))
            {
                clientsModel.Add(new ClientListModel
                {
                    Сlient = client,
                    //Department = db.Departments.FirstOrDefault(d => d.ID == currentWorker.ID),
                    RealAddress = db.Addresses.FirstOrDefault(a => a.ID == client.Real_addressId),
                    FormalAddress = db.Addresses.FirstOrDefault(a => a.ID == client.Formal_addressId),
                    //Worker = db.Workers.FirstOrDefault(w => w.ID == client.WorkerID)
                });
            }
            return View(clientsModel);
        }

        public IActionResult Schedule()
        {
            //var todayList;


            return View(sheduleModels);
        }
        [HttpGet]
        [Route("Worker/ClientPlan/{client_id:int}")]
        public IActionResult ClientPlan(int? client_id)
        {

            return View(sheduleModels.Where(m=>m.client.ID==client_id));
        }
        [HttpPost]
        public IActionResult ClientPlan(List<int> completeId)
        {
            int counter = 0;
            foreach(int complete in completeId)
            {
                var singleModel = sheduleModels.FirstOrDefault(s => s.id == complete);
                //////fixfix
                db.DoneWorks.Add(new DoneWork
                {
                    ID = db.DoneWorks.Count() + counter +1,
                    WorkerID = currentWorker.ID,
                    ClientID = singleModel.client.ID,
                    ServiceID = singleModel.service.ID,
                    Date_of_service = DateTime.Now
                });
                sheduleModels.Remove(sheduleModels.FirstOrDefault(s => s.id == complete));
                counter++;
            }
            db.SaveChanges();
            return RedirectToAction("Schedule");
        }
        public IActionResult ScheduleWeek()
        {
            var viewModel = new List<ClientWeekSTypesModel>();
            foreach(Client c in db.Clients.Where(c=>c.WorkerID==currentWorker.ID))
            {
                var typesList = new List<ServiceType>();
                foreach (ClientTypeOfService types in db.ClientTypeOfServices.Where(t => t.ClientID == c.ID))
                {
                    typesList.Add(db.ServiceTypes.FirstOrDefault(t => t.ID == types.ServiceTypeID));
                }
                viewModel.Add(new ClientWeekSTypesModel
                {
                    Client = c,
                    Week = new WeekModel(db.Schedules.Where(s => s.ClientID == c.ID).ToList()),
                    Types=typesList
                });
            }
            return View(viewModel);
        }

    }
}