using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using Shop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Service.Implements
{
    public class PaymentService : Service<Payment>, IPaymentService
    {
        public IUnitOfWork _unitOfWork;
        public IPaymentRepository _paymentRepository;
        public PaymentService(IUnitOfWork unitOfWork, IPaymentRepository paymentRepository)
        {
            _unitOfWork = unitOfWork;
            _paymentRepository = paymentRepository;
        }

        public bool CheckExistsById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Payment Payment)
        {
            _paymentRepository.Delete(Payment);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _paymentRepository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Payment>> GetAllAsync()
        {
            return await _paymentRepository.GetAllAsync();
        }

        public async Task<Payment> GetByIdAsync(int id)
        {
            return await _paymentRepository.GetByIdAsync(id);
        }

        public async Task InsertAsync(Payment Payment)
        {
            await _paymentRepository.InsertAsync(Payment);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Payment Payment)
        {
            _paymentRepository.Update(Payment);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
