using Appartment_Application.Repositories.PaymentRepositories;
using Appartment_Domain.Data;
using Appartment_Domain.Dtos;
using Microsoft.AspNetCore.Mvc;
namespace Appartment_Api.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class PayemtController : ControllerBase
{
    private readonly IPaymentRepository _paymentRepository;

    public PayemtController(IPaymentRepository paymentRepository)
    {
        _paymentRepository = paymentRepository;
    }

    [HttpGet]
    public IActionResult PaymentGetAll()
    {
        var result = _paymentRepository.GetAllAsync();
        return Ok(result.Result);
    }
    [HttpPost]
    public IActionResult PaymetCreated(PaymentDto payment)
    {
        var result = _paymentRepository.CreateAsync(payment);
        return Ok(result.Result);
    }
    [HttpPut]
    public IActionResult PaymentUpdated(int Id, PaymentDto payment)
    {
        var result = _paymentRepository.UpdateAsync(Id, payment);
        return Ok(result.Result);
    }
    [HttpDelete]
    public IActionResult PaymentDelete(int Id)
    {
        var result = _paymentRepository.DeleteAsync(Id);
        return Ok(result.Result);
    }
    [HttpGet]
    public IActionResult PaymentGetById(int id)
    {
        var result = _paymentRepository.GetByIdAsync(id);
        return Ok(result.Result);
    }
}
