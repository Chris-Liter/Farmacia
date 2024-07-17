using Farmacia.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.ViewModel
{
    internal class VentasViewModel: FacturaModel
    {
        public cliente Person {  get; set; }
        public ProductsModel MiProducto { get; set; }
        public string SearchParam {  get; set; }

        public ObservableCollection<ProductModel> _invoiceDetailModels {  get; set; }

        public ObservableCollection<ProductModel> InvoiceDetailModels
        {
            get
            {
                return _invoiceDetailModels;
            }set
            {
                _invoiceDetailModels = value; OnPropertyChanged();
            }
        }


        public VentasViewModel()
        {
            Person = new cliente();
        }
    }
}
