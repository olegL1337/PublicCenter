using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class ScheduleRepository : IRepository<Schedule>
    {
        private PublicContext db;

        public ScheduleRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public Schedule Create(Schedule item)
        {
            db.Schedules.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.Schedules.Find(id);
            if (item != null)
            {
                db.Schedules.Remove(item);
            }
        }

        public IEnumerable<Schedule> Find(Func<Schedule, bool> predicate)
        {
            return db.Schedules.Where(predicate).ToList();
        }

        public Schedule Get(int id)
        {
            return db.Schedules.Find(id);
        }

        public IEnumerable<Schedule> GetAll()
        {
            return db.Schedules;
        }

        public Schedule Update(Schedule item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
