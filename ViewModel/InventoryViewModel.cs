using Farmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Farmacia.ViewModel
{
    public class InventoryViewModel: ProductModel
    {
        public List<ProductModel> productos;
        public ProductModel selectedProduct;
        public ProductModel SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; }
        }
        public InventoryViewModel()
        {
            Update();
        }
        public List<ProductModel> Productos { get { return productos; }  set { productos = value; } }
        public async void Update(ref List<ProductModel> productos)
        {
            string url = "http://localhost:8080/api/Producto";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                var jsonTransformado = JsonSerializer.Deserialize<List<ProductModel>>(json);
                
            }
        }

    }
}
