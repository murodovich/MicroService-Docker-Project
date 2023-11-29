using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tourism_Application.Dtos;
using Tourism_Infrastructure.Services.BookingServices;

namespace Tourism_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingGetAll()
        {
            var result = _bookingService.GetAll();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult BookingCreate(BookingDto bookingDto)
        {
            var result = _bookingService.Create(bookingDto);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult BookingGetById(int id)
        {
            var result = _bookingService.GetById(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult BookingUpdate(int id, BookingDto bookingDto)
        {
            var result = _bookingService.Update(id, bookingDto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult BookingDeleteById(int id)
        {
            var result = _bookingService.Delete(id);
            return Ok(result.Result);
        }
    }
}
