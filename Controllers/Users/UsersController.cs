using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolidTest.Services;
using SolidTest.Models;

namespace SolidTest.Controllers.Users
{
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository){
            _userRepository = userRepository;
        }
        [HttpGet]
        [Route("api/users")]
        public IEnumerable<User> GetUsers(){
            return _userRepository.GetAll();
        }
        [HttpGet]
        [Route("api/users/{id}")]
        public User Details(int id){
            return _userRepository.GetById(id);
        }


    }
}