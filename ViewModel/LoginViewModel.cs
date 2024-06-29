using CommunityToolkit.Mvvm.Input;
using Farmacia.Models;
using Farmacia.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;

namespace Farmacia.ViewModel
{
    public class LoginViewModel: UserModel
    {
        public RelayCommand LoginCommand {  get; set; }
        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(async () => await Login());
        }


        public async Task Login()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "http://localhost:8080/api/Usuarios";
                    //UserModel usuariosView = this;
                    var resp = await client.GetAsync($"{url}/login/{Name}/{Password}");
                    if(!resp.IsSuccessStatusCode)
                    {
                        MessageBox.Show("ERROR","Fallo de la conexion", MessageBoxButton.OK);
                    }
                    else
                    {
                        MainWindow main = new MainWindow();
                        main.Show();
                        var iniciarSesion = MainPage.Current;
                        iniciarSesion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
