using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.ViewModel.ViewModels
{
   public class BaseViewModel
    {
        public int Id { get; set; }
        public string InsertedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
