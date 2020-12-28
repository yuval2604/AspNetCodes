using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetToDoList.Entities;

namespace AspNetToDoList.Contexts
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options)
           : base(options)
        {
            //  Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskSchema>()
                 .HasData(
                new TaskSchema()
                {
                    Id = 1,
                    title = "New York City",
                    Description = "The one with that big park.",
                    Status = false
                },
                new TaskSchema()
                {
                    Id = 2,
                    title = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    Status = false

                },
                new TaskSchema()
                {
                    Id = 3,
                    title = "Paris",
                    Description = "The one with that big tower.",
                    Status = false
                });


            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
