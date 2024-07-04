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
    public class UsuariosViewModel:UserModel
    {
        public RelayCommand AddOrEditUser {  get; set; }
        public RelayCommand DeleteUser { get; set; }
        public RelayCommand OpenCreate { get; set; }
        public RelayCommand OpenEdit { get; set; }


        public UserModel UserSelected { get; set; }
        public ObservableCollection<UserModel> users;
        public ObservableCollection<UserModel> Users{ get { return users; } set { users= value; OnPropertyChanged(nameof(Users)); } }
        public string permisoSeleccionado {  get; set; }
        public PermisosUsuario PermisoSeleccionado
        {
            get { if (permisoSeleccionado == "Administrador")
                {
                    return PermisosUsuario.administrador;
                }
                else
                {
                    return PermisosUsuario.empleado;
                }
            }


            set {
                if (PermisosUsuario.administrador == permiso)
                {
                    permiso = value;
                }
                else
                {
                    permiso = PermisosUsuario.empleado;
                }
                    
                    OnPropertyChanged(); 
            }
        }
        public string searchUser {  get; set; }
        private readonly IEntityView _entityView;
        public UsuariosViewModel(IEntityView entityView) 
        { 
            _entityView = entityView;
            Users = new ObservableCollection<UserModel>();
            Update();
            OpenCreate = new RelayCommand(async () => await AbrirCrear());
            OpenEdit = new RelayCommand(async ()=> await AbrirUpdate());
            AddOrEditUser = new RelayCommand(async () => await CreateOrUpdate());
            DeleteUser = new RelayCommand(async () => await Delete());
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

                    var jsonDeserialize = JsonSerializer.Deserialize<List<UserModel>>(json, options);
                        foreach(var item in jsonDeserialize)
                    {
                        Users.Add(item);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        public async Task AbrirCrear()
        {
            try
            {
                ManipularUser manipularUser = new ManipularUser(_entityView);
                if( manipularUser != null)
                {
                    manipularUser.Show();
                }
                else
                {

                }
            }
            catch(Exception e)
            {

            }
        }

        public async Task AbrirUpdate()
        {
            try
            {
                if(UserSelected != null)
                {
                    ManipularUser manipularUser = new ManipularUser(_entityView, UserSelected);
                    if (manipularUser != null)
                    {
                        manipularUser.Show();
                    }
                    else
                    {

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
                        UserModel model = new UserModel() { id = UserSelected.id, nombre = nombre, email = email, fechanacimiento = fechanacimiento, passwords = passwords, permiso = PermisoSeleccionado };
                        string json = JsonSerializer.Serialize(model);
                        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await http.PutAsync($"{url}/{UserSelected.id}", content);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Se modifico el usuario con exito", "Exito", MessageBoxButton.OK);
                        }
                    }
                }
                else
                {
                    using (HttpClient http = new HttpClient())
                    {
                        UserModel model = new UserModel() { id = 0, nombre = nombre, email = email, fechanacimiento = fechanacimiento, passwords = passwords, permiso = PermisoSeleccionado };
                        string json = JsonSerializer.Serialize(model);
                        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await http.PostAsync(url, content);
                        if (response.IsSuccessStatusCode)
                        {
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
                    }
                }
            }
            catch(Exception e)
            {

            }
        }
    }
}
