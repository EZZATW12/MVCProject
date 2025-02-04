using Microsoft.EntityFrameworkCore;
using MVC.DAL.Models.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.persistance.Data
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = ProjectMVC;Trusted_Connection=True; TrustedServerCertificate = true;");
        }
        public DbSet<Department> Departments { get; set; }
    }
}
