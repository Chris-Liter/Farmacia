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
    public class UsuariosViewModel : UserModel, IEntityView
    {
        public RelayCommand AddOrEditUser {  get; set; }
        public RelayCommand DeleteUser { get; set; }
        public RelayCommand OpenCreate { get; set; }
        public RelayCommand OpenEdit { get; set; }


        public UserModel UserSelected { get; set; }
        private ManipularUser manipularUser;
        public ObservableCollection<UserModel> users;
        public ObservableCollection<UserModel> Users{ get { return users; } set { users= value; OnPropertyChanged(nameof(Users)); } }
        public string permisoSeleccionado {  get; set; }
        public string PermisoSeleccionado
        {
            get { if (permisoSeleccionado == "Administrador")
                {
                    return Permisos.Administrador.ToString();
                }
                else
                {
                    return Permisos.Empleado.ToString();
                }
            }


            set {
                if (Permisos.Administrador.ToString() == permisos)
                {
                    permisos = value;
                }
                else
                {
                    permisos = Permisos.Empleado.ToString();
                }

                OnPropertyChanged(); 
            }
        }
        public string searchUser {  get; set; }
        private readonly IEntityView _entityView;
        public UsuariosViewModel(IEntityView entityView) 
        { 
            Users = new ObservableCollection<UserModel>();
            Update();
            OpenCreate = new RelayCommand( () =>  AbrirCrear());
            OpenEdit = new RelayCommand(()=>  AbrirUpdate());
            AddOrEditUser = new RelayCommand(async () => await CreateOrUpdate());
            DeleteUser = new RelayCommand(async () => await Delete());
            _entityView = entityView;
        }



        public async Task Update()
        {
            try
            {
                string url = $"{URLRep.URL}/Usuarios";
                Users.Clear();
                using(HttpClient http = new HttpClient())
                {
                    var response = await http.GetAsync(url);
                    string json = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict
                    };

                    var jsonDeserialize = JsonSerializer.Deserialize <List<UserModel>>(json, options);
                    foreach(UserModel item in jsonDeserialize)
                    {
                        UserModel user =  convert(item);
                        Users.Add(user);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        static UserModel convert(UserModel valor)
        {
            if (valor.permisos == "1")
            {
                valor.permisos = "Administrador";
                return valor;
            }
            else
            {
                valor.permisos = "Empleado";
                return valor;
            }
        }

        public void AbrirCrear()
        {
            try
            {
                
                if( manipularUser == null || manipularUser.IsVisible == false)
                {
                    manipularUser = new ManipularUser(_entityView);
                    manipularUser.Show();
                }
                else
                {
                    manipularUser.Close();
                    manipularUser = new ManipularUser(_entityView);
                    manipularUser.Show();
                }
            }
            catch(Exception e)
            {

            }
        }

        public void AbrirUpdate()
        {
            try
            {
                if(UserSelected != null)
                {
                    
                    if (manipularUser != null)
                    {
                        manipularUser = new ManipularUser(this, UserSelected);
                        manipularUser.Show();
                    }
                    else
                    {
                        manipularUser.Close();
                        manipularUser = new ManipularUser(this, UserSelected);
                        manipularUser.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario para modificarlo", "Error", MessageBoxButton.OK);
                }
            }
            catch (Exception e)
            {

            }
        }

        public async Task CreateOrUpdate()
        {
            try
            {
                string url = $"{URLRep.URL}/Usuarios";
                if (UserSelected != null)
                {
                    using (HttpClient http = new HttpClient())
                    {
                        UserModel model = new UserModel() { id = UserSelected.id, nombre = nombre, email = email, fechanacimiento = fechanacimiento, passwords = passwords, permisos = permisos };
                        string json = JsonSerializer.Serialize(model);
                        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await http.PutAsync($"{url}/{UserSelected.id}", content);
                        if (response.IsSuccessStatusCode)
                        {
                            var miVentana = ManipularUser.Current;
                            miVentana.Close();
                            _entityView.update();
                            MessageBox.Show("Se modifico el usuario con exito", "Exito", MessageBoxButton.OK);
                        }
                    }
                }
                else
                {
                    using (HttpClient http = new HttpClient())
                    {
                        UserModel model = new UserModel() { id = 0, nombre = nombre, email = email, fechanacimiento = fechanacimiento, passwords = passwords, permisos = permisos };
                        string json = JsonSerializer.Serialize(model);
                        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await http.PostAsync(url, content);
                        if (response.IsSuccessStatusCode)
                        {
                            var miVentana = ManipularUser.Current;
                            miVentana.Close();
                            _entityView.update();
                            MessageBox.Show("Se agrego el nuevo usuario con exito", "Exito", MessageBoxButton.OK);
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
            string url = $"{URLRep.URL}/Usuarios";
            try
            {
                if(UserSelected != null)
                {
                    using(HttpClient http = new HttpClient())
                    {
                        var response = await http.DeleteAsync($"{url}/{UserSelected.id}");
                        if(response.IsSuccessStatusCode)
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
            catch(Exception e)
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
