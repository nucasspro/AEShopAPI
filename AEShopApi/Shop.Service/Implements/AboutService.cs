using Shop.Domain.Entities;
using Shop.Domain.SeedWork;
using Shop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Service.Implements
{
    public class AboutService : Service<About>, IAboutService
    {
        public AboutService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
