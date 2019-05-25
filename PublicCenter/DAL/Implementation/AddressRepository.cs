using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class AddressRepository:IRepository<Address>
    {
        private PublicContext db;

        public AddressRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public Address Create(Address item)
        {
            db.Addresses.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.Addresses.Find(id);
            if (item != null)
            {
                db.Addresses.Remove(item);
            }
        }

        public IEnumerable<Address> Find(Func<Address, bool> predicate)
        {
            return db.Addresses.Where(predicate).ToList();
        }

        public Address Get(int id)
        {
            return db.Addresses.Find(id);
        }

        public IEnumerable<Address> GetAll()
        {
            return db.Addresses;
        }

        public Address Update(Address item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
