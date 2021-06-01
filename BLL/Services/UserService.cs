using BLL.Abstractions.Interfaces;
using Core.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserService _repository;

        public UserService(IUserService repository)
        {
            _repository = repository;
        }

        public List<User> LoadRecords()
        {
            return _repository.LoadRecords();
        }
    }
}