using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class ClientStatusRepository : IRepository<ClientStatus>
    {
        private PublicContext db;

        public ClientStatusRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public ClientStatus Create(ClientStatus item)
        {
            db.ClientStatuses.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.ClientStatuses.Find(id);
            if (item != null)
            {
                db.ClientStatuses.Remove(item);
            }
        }

        public IEnumerable<ClientStatus> Find(Func<ClientStatus, bool> predicate)
        {
            return db.ClientStatuses.Where(predicate).ToList();
        }

        public ClientStatus Get(int id)
        {
            return db.ClientStatuses.Find(id);
        }

        public IEnumerable<ClientStatus> GetAll()
        {
            return db.ClientStatuses;
        }

        public ClientStatus Update(ClientStatus item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
