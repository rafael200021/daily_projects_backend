using Daily_Project.IServices;
using Daily_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Daily_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : DefaultController<User>
    {
        public readonly IUserService _service;

        public UserController(IUserService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("Auth")]
        public async Task<IActionResult> GetUsuarioByToken()
        {

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))

                return Unauthorized("User not found");

            var user = await _service.GetById(int.Parse(userId));

            return Ok(user);
        }

    }
}
