using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class DoneWorkRepository : IRepository<DoneWork>
    {
        private PublicContext db;

        public DoneWorkRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public DoneWork Create(DoneWork item)
        {
            db.DoneWorks.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.DoneWorks.Find(id);
            if (item != null)
            {
                db.DoneWorks.Remove(item);
            }
        }

        public IEnumerable<DoneWork> Find(Func<DoneWork, bool> predicate)
        {
            return db.DoneWorks.Where(predicate).ToList();
        }

        public DoneWork Get(int id)
        {
            return db.DoneWorks.Find(id);
        }

        public IEnumerable<DoneWork> GetAll()
        {
            return db.DoneWorks;
        }

        public DoneWork Update(DoneWork item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
