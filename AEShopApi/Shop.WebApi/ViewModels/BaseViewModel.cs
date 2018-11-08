using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebApi.ViewModels
{
    public class BaseViewModel
    {
        public DateTime InsertedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
