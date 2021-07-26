using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsingEF
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //"Server=(localdb)\\mssqllocaldb;Database=PersonDatabase;Trusted_Connection=True;MultipleActiveResultSets=true"
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PersonDatabase;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
