using BluePrintApi.Model;
using BluePrintApi.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BluePrintApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[EnableCors("AllowOrigin")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("authenticateuser")]
        public async Task<IActionResult> AuthenticateUser(User user)
        {
            var result = await _userRepository.GetUser(user.Email,user.Password);

            return Ok(result);
        }

    }
}
