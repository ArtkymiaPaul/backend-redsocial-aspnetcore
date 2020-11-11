using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_redsocial_aspnetcore.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_redsocial_aspnetcore.Context
{
    public class RedSocialContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public RedSocialContext(DbContextOptions<RedSocialContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("User").HasKey(p => p.Id);
            builder.Entity<User>().ToTable("User").Property("Id").ValueGeneratedOnAdd();
            builder.Entity<Follow>().ToTable("Follow").HasKey(p => p.Id);
            builder.Entity<Follow>().ToTable("Follow").Property("Id").ValueGeneratedOnAdd();
            builder.Entity<Publication>().ToTable("Publication").HasKey(p => p.Id);
            builder.Entity<Publication>().ToTable("Publication").Property("Id").ValueGeneratedOnAdd();
            builder.Entity<Message>().ToTable("Message").HasKey(p => p.Id);
            builder.Entity<Message>().ToTable("Message").Property("Id").ValueGeneratedOnAdd();
            builder.Entity<Follow>().HasOne<User>("User");
            builder.Entity<Follow>().HasOne<User>("Followed");
            builder.Entity<Publication>().HasOne<User>("User");
            builder.Entity<Message>().HasOne<User>("Emitter");
            builder.Entity<Message>().HasOne<User>("Receiver");

            //builder.Entity<UserRole>().HasOne<User>("User");

        }
    }
}
