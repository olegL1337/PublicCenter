using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private PublicContext db;
        private AddressRepository addressRepository;
        private ClientRepository ClientRepository;
        private ClientStatusRepository ClientStatusRepository;
        private ClientTypeOfServiceRepository ClientTypeOfServiceRepository;
        private DepartmentRepository departmentRepository;
        private DoneWorkRepository doneWorkRepository;
        private ScheduleRepository scheduleRepository;
        private ServiceRepository serviceRepository;
        private ServiceTypeRepository serviceTypeRepository;
        private StatusRepository statusRepository;
        private WorkerRepository workerRepository;

        public UnitOfWork(PublicContext context)
        {
            db = context;
        }

        public IRepository<Address> Addresses
        {
            get
            {
                if (addressRepository == null)
                    addressRepository = new AddressRepository(db);
                return addressRepository;
            }
        }

        public IRepository<Client> Clients
        {
            get
            {
                if (ClientRepository == null)
                    ClientRepository = new ClientRepository(db);
                return ClientRepository;
            }
        }

        public IRepository<ClientStatus> ClientStatuses
        {
            get
            {
                if (ClientStatusRepository == null)
                    ClientStatusRepository = new ClientStatusRepository(db);
                return ClientStatusRepository;
            }
        }

        public IRepository<ClientTypeOfService> ClientTypeServ
        {
            get
            {
                if (ClientTypeOfServiceRepository == null)
                    ClientTypeOfServiceRepository = new ClientTypeOfServiceRepository(db);
                return ClientTypeOfServiceRepository;
            }
        }

        public IRepository<Department> Departments
        {
            get
            {
                if (departmentRepository == null)
                    departmentRepository = new DepartmentRepository(db);
                return departmentRepository;
            }
        }

        public IRepository<DoneWork> DoneWorks
        {
            get
            {
                if (doneWorkRepository == null)
                    doneWorkRepository = new DoneWorkRepository(db);
                return doneWorkRepository;
            }
        }

        public IRepository<Schedule> Schedules
        {
            get
            {
                if (scheduleRepository == null)
                    scheduleRepository = new ScheduleRepository(db);
                return scheduleRepository;
            }
        }

        public IRepository<Service> Services
        {
            get
            {
                if (serviceRepository == null)
                    serviceRepository = new ServiceRepository(db);
                return serviceRepository;
            }
        }

        public IRepository<ServiceType> ServiceTypes
        {
            get
            {
                if (serviceTypeRepository == null)
                    serviceTypeRepository = new ServiceTypeRepository(db);
                return serviceTypeRepository;
            }
        }

        public IRepository<Status> Statuses
        {
            get
            {
                if (statusRepository == null)
                    statusRepository = new StatusRepository(db);
                return statusRepository;
            }
        }

        public IRepository<Worker> Workers
        {
            get
            {
                if (workerRepository == null)
                    workerRepository = new WorkerRepository(db);
                return workerRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
