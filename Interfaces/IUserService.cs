using FluentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI.Interfaces
{
    public interface IUserService
    {
        Task<IReadOnlyList<Users>> GetUsers();

        Task<Users> CreateUser(Users user);
    }
}
