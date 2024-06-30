using Farmacia.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Farmacia.ViewModel
{
    public class InventoryViewModel: ProductsModel
    {
        public ObservableCollection<ProductsModel> productos;
        public ProductModel selectedProduct;
        public ProductModel SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; }
        }
        public InventoryViewModel()
        {
            Productos = new ObservableCollection<ProductsModel>();
            Update();
        }
        public ObservableCollection<ProductsModel> Productos { get { return productos; }  set { productos = value; OnPropertyChanged(nameof(Productos)); } }
        public async Task Update()
        {
            string url = "http://localhost:8080/api/Producto";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict
                };

                var jsonTransformado = JsonSerializer.Deserialize<List<ProductsModel>>(json, options);
               
                foreach (var  item in jsonTransformado)
                {
                    Productos.Add(item);
                }
            }
        }

    }
}
