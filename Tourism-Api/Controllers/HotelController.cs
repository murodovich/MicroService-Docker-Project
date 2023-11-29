using Microsoft.AspNetCore.Mvc;
using Tourism_Application.Dtos;
using Tourism_Infrastructure.Services.HotelServices;

namespace Tourism_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public IActionResult HotelGetAll()
        {

            var res = _hotelService.GetAll();
            return Ok(res.Result);
        }
        [HttpPost]
        public IActionResult HotelCreate(HotelDto hotelDto)
        {
            var result = _hotelService.Create(hotelDto);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult HotelGetById(int id)
        {
            var result = _hotelService.GetById(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult HotelUpdate(int id, HotelDto hotelDto)
        {
            var result = _hotelService.Update(id, hotelDto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult HotelDelete(int id)
        {
            var result = _hotelService.Delete(id);
            return Ok(result.Result);
        }

    }
}
