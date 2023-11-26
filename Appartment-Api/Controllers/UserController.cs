using Appartment_Application.Repositories.UserRepositories;
using Appartment_Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Appartment_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userrepository;

        public UserController(IUserRepository userrepository)
        {
            _userrepository = userrepository;
        }

        [HttpGet]
        public IActionResult UserGetAll()
        {
            var result = _userrepository.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult UserCreate(UserDto userDto)
        {
            var result = _userrepository.CreateAsync(userDto);
            return Ok(result.Result);
        }
    }
}
