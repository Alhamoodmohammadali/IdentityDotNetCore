using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement_5.Models;
namespace UserManagement_5.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomApplictionUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        /*
         * steps for rename tables
         * 1- override for methode OnModelCreating and rename all tables 
         * 2- in manager Console : add-migration ReNameIdentityTable
         * 2- in manger Cosnole : update-database
         */
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CustomApplictionUser>().ToTable("Users", "securety");
            builder.Entity<IdentityRole>().ToTable("Roles", "securety");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "securety");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "securety");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "securety");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "securety");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "securety");
        }
    }
}
