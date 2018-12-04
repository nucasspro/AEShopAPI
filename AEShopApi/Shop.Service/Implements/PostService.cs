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
    public class PostService : Service<Post>, IPostService
    {
        public IPostRepository _postRepository;
        public IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork, IPostRepository postRepository)
        {
            _unitOfWork = unitOfWork;
            _postRepository = postRepository;
        }

        public bool CheckExistsById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteAsync(Post post)
        {
            await _postRepository.DeleteAsync(post);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _postRepository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            return await _postRepository.GetAllAsync();
        }

        public async Task<Post> GetByIdAsync(int id)
        {
            return await _postRepository.GetByIdAsync(id);
        }

        public async Task InsertAsync(Post post)
        {
            await _postRepository.InsertAsync(post);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Post post)
        {
            _postRepository.Update(post);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
