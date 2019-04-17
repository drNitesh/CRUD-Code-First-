using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class UserDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {

        }
        public DbSet<CodeFirst.Models.UserRegistration> UserRegistration { get; set; }
        public DbSet<CodeFirst.Models.UserLogin> UserLogin { get; set; }
        public DbSet<CodeFirst.Models.UserProfile> UserProfile { get; set; }
    }
}


