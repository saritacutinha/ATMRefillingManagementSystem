using ATMRefillingManagementSystem.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMRefillingManagementSystem.Data
{
    public class ATMRefillingManagementSystemDbContext : DbContext
    {
        public DbSet<Bank> Banks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ATMRefillingManagementSystem;Integrated Security=SSPI;MultipleActiveResultSets=true;");
        }
    }
}
