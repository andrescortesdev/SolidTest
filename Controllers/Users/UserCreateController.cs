using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolidTest.Models;
using SolidTest.Services;

namespace SolidTest.Controllers.Users
{
    public class UserCreateController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserCreateController(IUserRepository userRepository){
            _userRepository = userRepository;
        }
        [HttpPost]
        [Route("api/users")]
        public IActionResult Create([FromBody] User user){
           _userRepository.add(user);
           return Ok();
            
        }
    }
}