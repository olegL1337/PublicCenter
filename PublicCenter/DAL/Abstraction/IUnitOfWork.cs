using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Abstractions
{
    interface IUnitOfWork:IDisposable
    {
        IRepository<Address> Addresses { get; }
        IRepository<Client> Clients { get; }
        IRepository<ClientStatus> ClientStatuses { get; }
        IRepository<ClientTypeOfService> ClientTypeServ { get; }
        IRepository<Department> Departments { get; }
        IRepository<DoneWork> DoneWorks { get; }
        IRepository<Schedule> Schedules { get; }
        IRepository<Service> Services { get; }
        IRepository<ServiceType> ServiceTypes { get; }
        IRepository<Status> Statuses { get; }
        IRepository<Worker> Workers { get; }
        void Save();
    }
}
