﻿using System;
using Microsoft.EntityFrameworkCore;
using Model;

namespace TypeScript.Persistence
{
    public class ValuesDataContext : DbContext
    {
        public ValuesDataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(
                new Value { Id = 1, Name = "Value 101" },
                new Value { Id = 2, Name = "Value 102" },
                new Value { Id = 3, Name = "Value 103" }
             );
        }

    }
}
