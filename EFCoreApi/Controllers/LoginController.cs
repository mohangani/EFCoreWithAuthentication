using EFCoreApi.Infrastructure;
using EFCoreApi.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogin _login;

        public LoginController(ILogin login)
        {
            _login = login;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDto loginInfo)
        {
            var token = _login.Authenticate(loginInfo);
            if (token is null)
                return BadRequest();

            return Ok(token);
        }


    }
}
