using CommunityToolkit.Mvvm.Input;
using Farmacia.Models;
using Farmacia.Views.Screens;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows;

namespace Farmacia.ViewModel
{

    public class InventoryViewModel : ProductsModel, IEntityView
    {
        public RelayCommand EditarProducto { get; set; }
        public RelayCommand CreateOrUpdate {  get; set; }
        public RelayCommand DeleteProduct { get; set; }
        public RelayCommand Open {  get; set; }
        private ManipularInventory inventory;

        public ObservableCollection<ProductsModel> productos;
        public ProductsModel selectedProduct;
        private readonly IEntityView entityView;

        public string search;

        public string SearchParameter
        {
            get
            {
                if (search == null)
                {
                    search = string.Empty;
                }
                return search;
            }
            set
            {
                search = value;
                Search(search);
                OnPropertyChanged();
            }
        }
        public ProductsModel SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; OnPropertyChanged(); }
        }
        public InventoryViewModel(IEntityView entityView)
        {
            Productos = new ObservableCollection<ProductsModel>();
            EditarProducto = new RelayCommand(async () => await Editar());
            CreateOrUpdate = new RelayCommand(async () => await CreateOrUpdateProducto());
            DeleteProduct = new RelayCommand(async () => await Delete());
            Open = new RelayCommand(async () => await Abrir());
            Productos.Clear();
            Update();

            this.entityView = entityView;
        }
        public ObservableCollection<ProductsModel> Productos { get { return productos; } set { productos = value; OnPropertyChanged(nameof(Productos)); } }


        public async Task Search(string search)
        {
            try
            {
                if (string.IsNullOrEmpty(search))
                {
                    Productos.Clear();
                    await Update();
                }
                else
                {
                    Productos.Clear();

                    await Update();
                    var response = productos;
                    Productos = new ObservableCollection<ProductsModel>(response.Where(name => name.nombre.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0));

                }
            }
            catch (Exception ex)
            {

            }
        }


        public async Task Update()
        {
            string url = $"{URLRep.URL}/Producto";
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
                Productos.Clear();
                productos.Clear();

                foreach (var item in jsonTransformado)
                {
                    Productos.Add(item);
                }
            }
        }
        public async Task Editar()
        {
            try
            {
                if (SelectedProduct != null)
                {
                    
                    if (inventory == null || inventory.IsVisible == false)
                    {
                        inventory = new ManipularInventory(this, SelectedProduct);
                        inventory.Show();
                    }
                    else
                    {
                        inventory.Close();
                        inventory = new ManipularInventory(this, SelectedProduct);
                        inventory.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona primero un producto para editarlo", "Error", MessageBoxButton.OK);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public async Task Abrir()
        {
            try
            {
                if (inventory == null || inventory.IsVisible == false)
                {
                    inventory = new ManipularInventory(this);
                    inventory.Show();
                }
                else
                {
                    inventory.Close();
                    inventory = new ManipularInventory(this);
                    inventory.Show();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public async Task CreateOrUpdateProducto()
        {
            try
            {
                string url = $"{URLRep.URL}/Producto";
                using (HttpClient client = new HttpClient())
                {
                    if (SelectedProduct != null)
                    {
                        ProductsModel model = new ProductsModel() { id = SelectedProduct.id, codigo_producto = codigo_producto, iva = iva, nombre = nombre, precio = precio, stock = stock };
                        string json = JsonSerializer.Serialize(model);

                        StringContent contenido = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await client.PutAsync($"{url}/{SelectedProduct.id}", contenido);
                        if (response.IsSuccessStatusCode)
                        {
                            var miVentana = ManipularInventory.Current;
                            miVentana.Close();
                            //entityView.update();
                            MessageBox.Show("Se a modificado el producto con exito", "Exito", MessageBoxButton.OK);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        ProductsModel model = new () { id = 0, codigo_producto = codigo_producto, iva = iva, nombre = nombre, precio = precio, stock = stock };
                        string json = JsonSerializer.Serialize(model);

                        StringContent contenido = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await client.PostAsync($"{url}/crear", contenido);
                        if (response.IsSuccessStatusCode)
                        {
                            var miVentana = ManipularInventory.Current;
                            miVentana.Close();
                            entityView.update();
                            MessageBox.Show("Se a creado el producto con exito", "Exito", MessageBoxButton.OK);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public async Task Delete()
        {
            if(SelectedProduct!=null)
            {
                MessageBox.Show("Seguro que quieres eliminar este producto?", "Advertencia", MessageBoxButton.YesNo);
                if(MessageBoxResult.Yes.ToString() == "Yes")
                {
                    string url = $"{URLRep.URL}/Producto/{SelectedProduct.id}";
                    using(HttpClient client = new HttpClient())
                    {
                        var response = await client.DeleteAsync(url);
                        update();
                    }

                }
            }
        }

        public async void update()
        {
            await Update();
        }
    }
}
