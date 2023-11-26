using Appartment_Domain.Data;
using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Appartment_Application.Repositories.PaymentRepositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly ApartmentDBContext _dbContext;

        public PaymentRepository(ApartmentDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async ValueTask<int> CreateAsync(PaymentDto model)
        {
            Payment payment = new Payment();
            payment.PaymentDate = model.PaymentDate;
            payment.Amount = model.Amount;
            payment.ReservationId = model.ReservationId;
            payment.PaymentStatus = model.PaymentStatus;

            await _dbContext.payments.AddAsync(payment);
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }

        public async ValueTask<int> DeleteAsync(int Id)
        {
            var result = await _dbContext.payments.FirstOrDefaultAsync(x => x.PaymentId == Id);
            _dbContext.payments.Remove(result);
            var res = await _dbContext.SaveChangesAsync();
            return res;
        }

        public async ValueTask<List<Payment>> GetAllAsync()
        {
            var result = await _dbContext.payments.ToListAsync();
            return result;
        }

        public async ValueTask<Payment> GetByIdAsync(int Id)
        {
            var result = await _dbContext.payments.FirstOrDefaultAsync(x => x.PaymentId == Id);
            return result;
        }

        public async ValueTask<int> UpdateAsync(int Id, PaymentDto model)
        {
            var result = await _dbContext.payments.FirstOrDefaultAsync(x => x.PaymentId == Id);

            result.PaymentDate = model.PaymentDate;
            result.Amount = model.Amount;
            result.ReservationId = model.ReservationId;
            result.PaymentStatus = model.PaymentStatus;

            _dbContext.payments.Update(result);
            var res = await _dbContext.SaveChangesAsync();
            return res;
        }
    }
}
