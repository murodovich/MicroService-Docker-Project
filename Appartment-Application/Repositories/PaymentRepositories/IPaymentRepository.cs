using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;

namespace Appartment_Application.Repositories.PaymentRepositories;
public interface IPaymentRepository : IBaseRepository<Payment, PaymentDto>
{
}
