using CommunityToolkit.Mvvm.Input;
using Farmacia.Models;
using Farmacia.Services;
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
    public class ComprasViewModel : ProductsModel, IEntityView
    {
        public decimal subtotal {  get; set; }
        public decimal ivatotal {  get; set; }
        public decimal total { get; set; }
        public double idCliente;
        public cliente Person {  get; set; }
        
        public ProductsModel MiProducto { get; set; }
        public RelayCommand GuardarFactura { get; set; }

        public IEntityView entityView { get; set; }
        public ObservableCollection<ProductsModel> productos;
        public ObservableCollection<ProductsModel> Productos { get { return productos; } set { productos = value; OnPropertyChanged(nameof(Productos)); } }

        public DetalleFacturaModel DetalleFacturaModel { get; set; }
        public async Task<decimal> CalcularTotal()
        {
            subtotal = 0;
            ivatotal = 0;
            total = 0;
            foreach(var product in productos)
            {
                decimal tota = (decimal)product.precio;
                decimal iva = (decimal)product.iva;
                this.total += tota * (decimal)product.stock;
                this.total += iva;
            }
            return total;
        }

        public async Task<decimal> CalcularSubTotal()
        {
            subtotal = 0;
            ivatotal = 0;
            total = 0;
            foreach (var product in productos)
            {
                decimal tota = (decimal)product.precio * (decimal)product.stock;
                this.total += tota;
            }
            return total;
        }

        public async Task<decimal> CalcularIva()
        {
            subtotal = 0;
            ivatotal = 0;
            total = 0;
            foreach (var product in productos)
            {
                decimal iva = (decimal)product.iva * (decimal)product.stock;
                
                this.ivatotal += iva;
            }
            return ivatotal;
        }
        public static ComprasViewModel Instance { get; set; }

        public ComprasViewModel()
        {
            Productos = new ObservableCollection<ProductsModel>();
            MiProducto = new ProductsModel();
            Person = new cliente();
            GuardarFactura = new RelayCommand(async () => await CrearFactura());
            Instance = this;
        }

        public async Task CrearFactura()
        {
            try
            {
                string url = $"{URLRep.URL}/Factura";
                using(HttpClient http = new HttpClient())
                {
                    DateTime fecha = DateTime.Now;
                    string formattedDate = fecha.ToString("dd/MM/yy");

                    FacturaModel model = new FacturaModel()
                    {
                        fac_id = 1,
                        fac_fecha = formattedDate,
                        fac_numero = 0,
                        fac_subtotal = (double)CalcularSubTotal().Result,
                        fac_tipo = "0",
                        fac_total = (double)CalcularTotal().Result,
                        fac_total_iva = (double)CalcularIva().Result,
                        id_cliente = (int)idCliente,
                        id_usuario = (int)UserCache.Id,
                    };
                    string json = JsonSerializer.Serialize(model);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await http.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string leer = await response.Content.ReadAsStringAsync();

                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict
                        };

                        var conv = JsonSerializer.Deserialize<FacturaModel>(leer, options);
                        foreach(var item in Productos)
                        {
                            DetalleFacturaModel detalle = new DetalleFacturaModel()
                            {
                                code = "0",
                                det_cantidad = 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
