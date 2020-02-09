using System.Threading.Tasks;
using BackEnd.API.Data;
using BackEnd.API.Dtos;
using BackEnd.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            // Validate the request

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();
            
            if (await _repo.UserExists(userForRegisterDto.Username))
                return BadRequest("Username Already Exists");

            var userToCreate = new User
            {
                UserName = userForRegisterDto.Username
            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);
            
            return StatusCode(201);
        }

    }
}