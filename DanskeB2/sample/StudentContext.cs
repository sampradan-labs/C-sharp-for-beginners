using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace sample
{
    class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=studDB;Trusted_Connection=True;MultipleActiveResultSets=true");

        }
        //To add a migration
        //add-migration CreateSchoolDB

        //To update the db

    }
}
