using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class ServiceRepository : IRepository<Service>
    {
        private PublicContext db;

        public ServiceRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public Service Create(Service item)
        {
            db.Services.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.Services.Find(id);
            if (item != null)
            {
                db.Services.Remove(item);
            }
        }

        public IEnumerable<Service> Find(Func<Service, bool> predicate)
        {
            return db.Services.Where(predicate).ToList();
        }

        public Service Get(int id)
        {
            return db.Services.Find(id);
        }

        public IEnumerable<Service> GetAll()
        {
            return db.Services;
        }

        public Service Update(Service item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
