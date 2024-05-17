using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolidTest.Models;
using SolidTest.Services;
namespace SolidTest.Controllers.Users
{
    public class UserUpdateController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserUpdateController(IUserRepository userRepository){
            _userRepository = userRepository;
        }
        [HttpPut("{id}")]
        [Route("api/users/{id}/update")]
        public string Update(int id, [FromBody] User user){
            
            return "Falta Actualizar";
        }
        
    }
}