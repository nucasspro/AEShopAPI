using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using Shop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Implements
{
    public class AboutService : Service<About>, IAboutService
    {
        public IAboutRepository _aboutRepository;
        public IUnitOfWork _unitOfWork;

        public AboutService(IUnitOfWork unitOfWork, IAboutRepository aboutRepository)
        {
            _unitOfWork = unitOfWork;
            _aboutRepository = aboutRepository;
        }

        public bool CheckExistsById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteAsync(About about)
        {
            await _aboutRepository.DeleteAsync(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _aboutRepository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<About>> GetAllAsync()
        {
            return await _aboutRepository.GetAllAsync();
        }

        public async Task<About> GetByIdAsync(int id)
        {
            return await _aboutRepository.GetByIdAsync(id);
        }

        public async Task InsertAsync(About about)
        {
            await _aboutRepository.InsertAsync(about);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(About about)
        {
            _aboutRepository.Update(about);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
