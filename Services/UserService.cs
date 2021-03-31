using FluentAPI.Interfaces;
using FluentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPI.Services
{
    public class UserService : IUserService
    {

        IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task<IReadOnlyList<Users>> GetUsers()
        {
            return userRepository.ListAllAsync();
        }

        public Task<Users> CreateUser(Users user)
        {
            return userRepository.AddAsync(user);
        }
    }
}
