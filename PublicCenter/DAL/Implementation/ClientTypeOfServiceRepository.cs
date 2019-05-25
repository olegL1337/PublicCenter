using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class ClientTypeOfServiceRepository : IRepository<ClientTypeOfService>
    {
        private PublicContext db;

        public ClientTypeOfServiceRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public ClientTypeOfService Create(ClientTypeOfService item)
        {
            db.ClientTypeOfServices.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.ClientTypeOfServices.Find(id);
            if (item != null)
            {
                db.ClientTypeOfServices.Remove(item);
            }
        }

        public IEnumerable<ClientTypeOfService> Find(Func<ClientTypeOfService, bool> predicate)
        {
            return db.ClientTypeOfServices.Where(predicate).ToList();
        }

        public ClientTypeOfService Get(int id)
        {
            return db.ClientTypeOfServices.Find(id);
        }

        public IEnumerable<ClientTypeOfService> GetAll()
        {
            return db.ClientTypeOfServices;
        }

        public ClientTypeOfService Update(ClientTypeOfService item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
