using CommunityToolkit.Mvvm.Input;
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
    public class UsuariosViewModel:UserModel
    {
        public RelayCommand AddUser {  get; set; }
        public RelayCommand EditUser { get; set; }
        public RelayCommand DeleteUser { get; set; }
        public UserModel UserSelected { get; set; }
        public ObservableCollection<UserModel> users;
        public ObservableCollection<UserModel> Users{ get { return users; } set { users= value; OnPropertyChanged(nameof(Users)); } }
        public string searchUser {  get; set; }
        public UsuariosViewModel() 
        { 
            Users = new ObservableCollection<UserModel>();
            Update();
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


        public async Task CreateOrUpdate()
        {

        }

        public async Task Delete()
        {

        }
    }
}
