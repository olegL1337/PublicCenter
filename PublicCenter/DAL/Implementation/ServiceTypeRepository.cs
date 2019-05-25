using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class ServiceTypeRepository : IRepository<ServiceType>
    {
        private PublicContext db;

        public ServiceTypeRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public ServiceType Create(ServiceType item)
        {
            db.ServiceTypes.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.ServiceTypes.Find(id);
            if (item != null)
            {
                db.ServiceTypes.Remove(item);
            }
        }

        public IEnumerable<ServiceType> Find(Func<ServiceType, bool> predicate)
        {
            return db.ServiceTypes.Where(predicate).ToList();
        }

        public ServiceType Get(int id)
        {
            return db.ServiceTypes.Find(id);
        }

        public IEnumerable<ServiceType> GetAll()
        {
            return db.ServiceTypes;
        }

        public ServiceType Update(ServiceType item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
