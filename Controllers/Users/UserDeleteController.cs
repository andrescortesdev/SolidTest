using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SolidTest.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace SolidTest.Controllers.Users
{
    public class UserDeleteController : ControllerBase
    {
         private readonly IUserRepository _userRepository;
        public UserDeleteController(IUserRepository userRepository){
            _userRepository = userRepository;
        }
        [HttpDelete("{id}")]
        [Route("api/users/{id}")]

        public IActionResult Delete(int id){
            _userRepository.remove(id);
            return Ok();
        }
    }
}