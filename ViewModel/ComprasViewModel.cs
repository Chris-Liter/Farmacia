using Farmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.ViewModel
{
    public class ComprasViewModel
    {
        public cliente Person {  get; set; }

        public IEntityView entityView { get; set; }
        public ComprasViewModel()
        {
            Person = new cliente();
        }
    }
}
