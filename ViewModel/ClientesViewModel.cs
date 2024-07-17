using CommunityToolkit.Mvvm.Input;
using Farmacia.Models;
using Farmacia.Views.Screens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Farmacia.ViewModel
{
    class ClientesViewModel : cliente, IEntityView
    {

        public RelayCommand CreateOrUpdate {  get; set; }
        public RelayCommand Delete { get; set; }
        public RelayCommand AbrirCreat { get; set; }
        public RelayCommand AbrirUpdate { get; set; }
        public ObservableCollection<cliente> clientes { get; set; }
        public ObservableCollection<cliente> Clientes { get { return clientes; } set { clientes = value; OnPropertyChanged(nameof(Clientes)); } }
        public readonly IEntityView entity;
        public string SearchProduct {  get; set; }
        public cliente SelectedCliente {  get; set; }
        private ManipularCliente manipularCliente;
        public ClientesViewModel(IEntityView entityView)
        {
            this.entity = entityView;
            Clientes = new ObservableCollection<cliente>();
            AbrirCreat = new RelayCommand(() => AbrirCreate());
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


        public async Task<cliente> Search(string path)
        {
            await Update();
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    Clientes.Clear();
                    return null;
                }
                else
                {
                    var response = clientes;
                    Clientes = new ObservableCollection<cliente>(response.Where(o => o.cli_cedula == path));
                    cliente cli = null;
                    if(Clientes.Count >= 1)
                    {
                        foreach (cliente i in clientes)
                        {
                            cli = i;
                            return i;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"La cedula {path} no existe", "Error", MessageBoxButton.OK);
                    }
                    return cli;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("");
            }
        
        }

        public void AbrirCreate()
        {
            try
            {
                if (manipularCliente == null|| manipularCliente.IsVisible == false)
                {
                    manipularCliente = new ManipularCliente(this);
                    manipularCliente.Show();
                }
                else
                {
                    manipularCliente.Close();
                    manipularCliente = new ManipularCliente(this);
                    manipularCliente.Show();
                }
            }
            catch(Exception ex)
            {

            }
        }

        public async void update()
        {
            await Update();
        }
    }
}
