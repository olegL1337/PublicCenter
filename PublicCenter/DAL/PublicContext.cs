using Microsoft.EntityFrameworkCore;
using PublicCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicCenter.DAL
{
    public class PublicContext:DbContext
    {
        public PublicContext(DbContextOptions<PublicContext> options)
            : base(options)
        { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientStatus> ClientStatuses { get; set; }
        public DbSet<ClientTypeOfService> ClientTypeOfServices { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DoneWork> DoneWorks { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host = localhost; Port = 5432; Database = Public; Username = postgres; Password = postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientStatus>().HasKey(c => new { c.ClientID, c.StatusId });
            modelBuilder.Entity<ClientTypeOfService>().HasKey(c => new { c.ClientID, c.ServiceID });
            modelBuilder.Entity<Schedule>().HasKey(c => new { c.ClientID, c.Day });
            modelBuilder.Entity<Client>().HasAlternateKey(u => u.Identify_number);
        }
    }
}
