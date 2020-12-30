using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestApiCourceTurorial.Domain;

namespace RestApiCourceTurorial.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Post> Posts { get; set; }
       

        

        //public DbSet<Tag> Tags { get; set; }

        //public DbSet<PostTag> PostTags { get; set; }

        public DbSet<RefreshToken> RefreshTokens { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<PostTag>().Ignore(xx => xx.Post).HasKey(x => new { x.PostId, x.TagName });
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Post>()
            //      .HasData(
            //     new Post()
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Yuval"

            //     },
            //     new Post()
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Antwerp"

            //     });

            base.OnModelCreating(modelBuilder);
        }
    }
}
