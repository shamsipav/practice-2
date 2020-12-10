using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.HomeViewModels
{
    public class IndexViewModel
    {
        public InputDataModel Input { get; set; }

        public int Result { get; set; }

        public IndexViewModel()
        {
            Input = new InputDataModel();
        }
    }
}
