using Microsoft.EntityFrameworkCore;
using PublicCenter.DAL.Abstractions;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL.Implementation
{
    public class ClientRepository : IRepository<Client>
    {
        private PublicContext db;

        public ClientRepository(PublicContext peoplecontext)
        {
            db = peoplecontext;
        }

        public Client Create(Client item)
        {
            db.Clients.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var item = db.Clients.Find(id);
            if (item != null)
            {
                db.Clients.Remove(item);
            }
        }

        public IEnumerable<Client> Find(Func<Client, bool> predicate)
        {
            return db.Clients.Where(predicate).ToList();
        }

        public Client Get(int id)
        {
            return db.Clients.Find(id);
        }

        public IEnumerable<Client> GetAll()
        {
            return db.Clients;
        }

        public Client Update(Client item)
        {
            db.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
