using Farmacia.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.ViewModel
{
    public class ComprasViewModel : ProductsModel, IEntityView
    {
        public cliente Person {  get; set; }
        public ProductsModel MiProducto { get; set; }

        public IEntityView entityView { get; set; }
        public ObservableCollection<ProductsModel> productos;
        public ObservableCollection<ProductsModel> Productos { get { return productos; } set { productos = value; OnPropertyChanged(nameof(Productos)); } }

        public ComprasViewModel()
        {
            Productos = new ObservableCollection<ProductsModel>();
            MiProducto = new ProductsModel();
            Person = new cliente();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
