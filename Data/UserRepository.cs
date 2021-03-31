using FluentAPI.Interfaces;
using FluentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI.Data
{
    public class UserRepository : EfRepository<Users>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
