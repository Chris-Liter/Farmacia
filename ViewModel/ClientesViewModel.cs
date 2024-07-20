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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmacia.ViewModel
{
    public class ClientesViewModel : cliente, IEntityView
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
            CreateOrUpdate = new RelayCommand(async () => await CreateOrUpdateCliente());
            Delete = new RelayCommand(async () => await DeleteCliente());
            Update();
        }

        public string rolSeleccionado { get; set; }
        public string RolSeleccionado
        {
            get
            {
                if (rolSeleccionado == "Comprador")
                {
                    return TypePerson.comprador.ToString();
                }
                else
                {
                    return TypePerson.proveedor.ToString();
                }
            }


            set
            {
                if (TypePerson.comprador.ToString() == type_person)
                {
                    type_person = value;
                }
                else
                {
                    type_person = TypePerson.proveedor.ToString();
                }

                OnPropertyChanged();
            }
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

        public async Task CreateOrUpdateCliente()
        {
            try
            {
                string url = $"{URLRep.URL}/Clientes";
                using (HttpClient client = new HttpClient())
                {
                    if (SelectedCliente != null)
                    {
                        cliente model = new cliente() { cli_id = SelectedCliente.cli_id, cli_nombres = cli_nombres, cli_apellidos = cli_apellidos, 
                        cli_cedula = cli_cedula, cli_correo = cli_correo, cli_direccion = cli_direccion, cli_telefono = cli_telefono, type_person = type_person};
                        string json = JsonSerializer.Serialize(model);

                        StringContent contenido = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await client.PutAsync($"{url}/{SelectedCliente.cli_id}", contenido);
                        if (response.IsSuccessStatusCode)
                        {
                            var miVentana = ManipularInventory.Current;
                            miVentana.Close();
                            entity.update();
                            MessageBox.Show("Se a modificado el producto con exito", "Exito", MessageBoxButton.OK);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else
                    {
                        cliente model = new() {
                            cli_id = 0,
                            cli_nombres = cli_nombres,
                            cli_apellidos = cli_apellidos,
                            cli_cedula = cli_cedula,
                            cli_correo = cli_correo,
                            cli_direccion = cli_direccion,
                            cli_telefono = cli_telefono,
                            type_person = type_person
                        };
                        string json = JsonSerializer.Serialize(model);

                        StringContent contenido = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await client.PostAsync($"{url}", contenido);
                        if (response.IsSuccessStatusCode)
                        {
                            var miVentana = ManipularCliente.Current;
                            miVentana.Close();
                            entity.update();
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

        public async Task DeleteCliente()
        {
            string url = $"{URLRep.URL}/Clientes";
            try
            {
                if (SelectedCliente != null)
                {
                    using (HttpClient http = new HttpClient())
                    {
                        var response = await http.DeleteAsync($"{url}/{SelectedCliente.cli_id}");
                        if (response.IsSuccessStatusCode)
                        {
                            update();
                            MessageBox.Show("Se Elimino el usuario con exito", "Exito", MessageBoxButton.OK);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el usuario", "Fallo", MessageBoxButton.OK);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Verifique su conexion a internet", "Error", MessageBoxButton.OK);
            }
        }

        public async void update()
        {
            await Update();
        }
    }
}
