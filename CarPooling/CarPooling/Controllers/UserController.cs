using Contract.Domain;
using Contract.Domain.Models;
using Microsoft.AspNetCore.Mvc;
namespace CarPooling.Controllers
{
    [Route("User")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult RegisterUser(User user)
        {
            return Ok(_userService.RegisterUser(user));
        }
    }
}
