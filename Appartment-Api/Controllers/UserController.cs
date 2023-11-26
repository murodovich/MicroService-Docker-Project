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
        [HttpGet]
        public IActionResult UserGetById(int id)
        {
            var result = _userrepository.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult UserUpdate(int id , UserDto userDto)
        {
            var result = _userrepository.UpdateAsync(id, userDto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult UserDeleted(int id)
        {
            var result = _userrepository.DeleteAsync(id);
            return Ok(result.Result);
        }
    }
}
