using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
    }
}
