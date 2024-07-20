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
using System.Windows;

namespace Farmacia.ViewModel
{
    public class ComprasViewModel : ProductsModel, IEntityView
    {
        public decimal subtotal {  get; set; }
        public FacturaModel LaFactura { get; set; }
        public decimal ivatotal {  get; set; }
        public decimal total { get; set; }
        public double idCliente;
        public cliente Person {  get; set; }
        
        public ProductsModel MiProducto { get; set; }
        public RelayCommand GuardarFactura { get; set; }
        public RelayCommand AnularFactura { get; set; }

        public ObservableCollection<ProductsModel> productos;
        public ObservableCollection<ProductsModel> Productos { get { return productos; } set { productos = value; OnPropertyChanged(nameof(Productos)); } }
        public ObservableCollection<FacturaModel> facturas { get; set; }
        public ObservableCollection<FacturaModel> Facturas { get { return facturas; } set { facturas = value; OnPropertyChanged(nameof(Facturas)); } }

        public DetalleFacturaModel DetalleFacturaModel { get; set; }
        public FacturaModel SelectedFactura {  get; set; }
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
        public IEntityView entity { get; set; }

        public ComprasViewModel(IEntityView entity)
        {
            Productos = new ObservableCollection<ProductsModel>();
            Facturas = new ObservableCollection<FacturaModel>();
            MiProducto = new ProductsModel();
            LaFactura = new();
            Person = new cliente();
            GuardarFactura = new RelayCommand(async () => await CrearFactura());
            AnularFactura = new RelayCommand(async () => await Anular());
            Instance = this;
            Update();
            this.entity = entity;
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
                        fac_id = 0,
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

                        string urlDetalle = $"{URLRep.URL}/detalle_factura";

                        var conv = JsonSerializer.Deserialize<FacturaModel>(leer, options);
                        foreach(var item in Productos)
                        {
                            DetalleFacturaModel detalle = new DetalleFacturaModel()
                            {
                                det_id = 0,
                                det_iva = item.iva,
                                det_cantidad = (int)item.stock,
                                det_precio_unitario = item.precio,
                                det_subtotal = item.precio ,
                                det_total = item.precio,
                                factura_id = conv.fac_id,
                                producto_id = item.id
                            };
                            string jsonDetail = JsonSerializer.Serialize(detalle);
                            StringContent contentDet = new StringContent(jsonDetail, Encoding.UTF8, "application/json");
                            var responseDetail = await http.PostAsync(urlDetalle, contentDet);
                            
                        }
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Factura Creada", "Exito", MessageBoxButton.OK);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public async Task Update()
        {
            string url = $"{URLRep.URL}";
            try
            {
                using (HttpClient http = new HttpClient())
                {
                    Facturas.Clear();
                    var response = await http.GetAsync($"{url}/Factura");
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict
                        };
                        var lista = JsonSerializer.Deserialize<List<FacturaModel>>(json, options);
                        foreach (var i in lista)
                        {
                            FacturaModel model = convert(i);
                            Facturas.Add(model);
                        }
                    }
                }


            }
            catch (Exception ex)
            {

            }
        }


        public async Task Anular()
        {
            try
            {
                if (SelectedFactura != null)
                {
                    MessageBox.Show("Seguro que quieres anular la factura? Una vez anulada no puede retractarse", "Advertencia", MessageBoxButton.YesNo);
                    if(MessageBoxResult.Yes.ToString() == "Yes")
                    {
                        string url = $"{URLRep.URL}/Factura/{SelectedFactura.fac_id}";
                        using (HttpClient http = new HttpClient())
                        {
                            FacturaModel facturaModel = new FacturaModel() { fac_id = SelectedFactura.fac_id, fac_fecha = SelectedFactura.fac_fecha, fac_numero = SelectedFactura.fac_numero, fac_subtotal = SelectedFactura.fac_subtotal, fac_tipo = "1", fac_total = SelectedFactura.fac_total, fac_total_iva = SelectedFactura.fac_total_iva, id_cliente = SelectedFactura.id_cliente, id_usuario = SelectedFactura.id_usuario };
                            string json = JsonSerializer.Serialize(facturaModel);
                            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                            var response = await http.PutAsync(url, content);
                            if (response.IsSuccessStatusCode)
                            {
                                entity.update();
                                MessageBox.Show("Factura anulada con exito", "Mensaje", MessageBoxButton.OK);
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Selecciona una factura para anularla", "Error", MessageBoxButton.OK);
                }
            }catch (Exception ex)
            {

            }
        }
        static FacturaModel convert(FacturaModel fac)
        {
            if(fac.fac_tipo == "0")
            {
                fac.fac_tipo = "Activo";
                return fac;
            }
            else
            {
                fac.fac_tipo = "Anulado";
                return fac;
            }
        }
        public async void update()
        {
            await Update();
        }
    }
}
