using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class DepartmentRepository : IRepository<Department>
    {
        private PublicContext db;

        public DepartmentRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public Department Create(Department item)
        {
            db.Departments.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.Departments.Find(id);
            if (item != null)
            {
                db.Departments.Remove(item);
            }
        }

        public IEnumerable<Department> Find(Func<Department, bool> predicate)
        {
            return db.Departments.Where(predicate).ToList();
        }

        public Department Get(int id)
        {
            return db.Departments.Find(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return db.Departments;
        }

        public Department Update(Department item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
