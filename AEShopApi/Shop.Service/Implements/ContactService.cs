using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using Shop.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Service.Implements
{
    public class ContactService : Service<Contact>, IContactService
    {
        public IContactRepository _contactRepository;
        public IUnitOfWork _unitOfWork;

        public ContactService(IUnitOfWork unitOfWork, IContactRepository contactRepository)
        {
            _unitOfWork = unitOfWork;
            _contactRepository = contactRepository;
        }

        public bool CheckExistsById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteAsync(Contact contact)
        {
            await _contactRepository.DeleteAsync(contact);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _contactRepository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Contact>> GetAllAsync()
        {
            return await _contactRepository.GetAllAsync();
        }

        public async Task<Contact> GetByIdAsync(int id)
        {
            return await _contactRepository.GetByIdAsync(id);
        }

        public async Task InsertAsync(Contact contact)
        {
            await _contactRepository.InsertAsync(contact);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Contact contact)
        {
            _contactRepository.Update(contact);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}