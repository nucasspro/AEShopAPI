using Shop.Domain.Entities;
using Shop.Domain.SeedWork;
using Shop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Service.Implements
{
    public class PostService : Service<Post>, IPostService
    {
        public PostService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
