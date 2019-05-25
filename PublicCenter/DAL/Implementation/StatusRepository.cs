using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class StatusRepository : IRepository<Status>
    {
        private PublicContext db;

        public StatusRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public Status Create(Status item)
        {
            db.Statuses.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.Statuses.Find(id);
            if (item != null)
            {
                db.Statuses.Remove(item);
            }
        }

        public IEnumerable<Status> Find(Func<Status, bool> predicate)
        {
            return db.Statuses.Where(predicate).ToList();
        }

        public Status Get(int id)
        {
            return db.Statuses.Find(id);
        }

        public IEnumerable<Status> GetAll()
        {
            return db.Statuses;
        }

        public Status Update(Status item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
