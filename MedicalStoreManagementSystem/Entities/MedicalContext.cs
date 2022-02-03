using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Entities
{
    public class MedicalContext: IdentityDbContext
    {
        public MedicalContext(DbContextOptions<MedicalContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Sell> Sell { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

        }
    }
}
