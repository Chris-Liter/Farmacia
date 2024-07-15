using Farmacia.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Farmacia.ViewModel
{
    class ClientesViewModel : cliente, IEntityView
    {

        public ICommand CreateOrUpdate {  get; set; }
        public ICommand Delete { get; set; }
        public ICommand AbrirCreate { get; set; }
        public ICommand AbrirUpdate { get; set; }
        public ObservableCollection<cliente> clientes { get; set; }
        public ObservableCollection<cliente> Clientes { get { return clientes; } set { clientes = value; OnPropertyChanged(nameof(Clientes)); } }
        public readonly IEntityView entity;
        public string SearchProduct {  get; set; }
        public cliente SelectedCliente {  get; set; }
        public ClientesViewModel(IEntityView entityView)
        {
            this.entity = entityView;
            Clientes = new ObservableCollection<cliente>();
            Update();
        }

        public async Task Update()
        {
            string url = $"{URLRep.URL}";
            try
            {
                using(HttpClient http = new HttpClient())
                {
                    Clientes.Clear();
                    var response = await http.GetAsync($"{url}/Clientes");
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict
                        };
                        var lista = JsonSerializer.Deserialize<List<cliente>>(json, options);
                        foreach(var i in lista)
                        {
                            cliente client = convert(i);
                            Clientes.Add(client);
                        }
                    }
                }


            }catch (Exception ex)
            {

            }
        }
        static cliente convert(cliente valor)
        {
            if (valor.type_person == "1")
            {
                valor.type_person = "Comprador";
                return valor;
            }
            else
            {
                valor.type_person = "Vendedor";
                return valor;
            }
        }

        public async void update()
        {
            await Update();
        }
    }
}
