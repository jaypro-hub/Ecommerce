﻿using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;

namespace Ecommerce.Repo
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());

        }
        public DbSet<User> Users { get; set; }

    }
}
