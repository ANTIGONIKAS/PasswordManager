using Microsoft.EntityFrameworkCore;
using PasswordManager.EF.Configuration;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF.Context {
    public class ApplicationContext:DbContext {
        public DbSet<UserEntry> UserEntries { get; set; }
        public DbSet<PasswordEntry> PasswordEntries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntryConfiguration());
            modelBuilder.ApplyConfiguration(new PasswordEntryConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PasswordManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
