using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class WorkerRepository : IRepository<Worker>
    {
        private PublicContext db;

        public WorkerRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public Worker Create(Worker item)
        {
            db.Workers.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.Workers.Find(id);
            if (item != null)
            {
                db.Workers.Remove(item);
            }
        }

        public IEnumerable<Worker> Find(Func<Worker, bool> predicate)
        {
            return db.Workers.Where(predicate).ToList();
        }

        public Worker Get(int id)
        {
            return db.Workers.Find(id);
        }

        public IEnumerable<Worker> GetAll()
        {
            return db.Workers;
        }

        public Worker Update(Worker item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
