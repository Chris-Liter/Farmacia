using CommunityToolkit.Mvvm.Input;
using Farmacia.Models;
using Farmacia.Services;
using Farmacia.Views;
using System.Net.Http;
using System.Text.Json;
using System.Windows;

namespace Farmacia.ViewModel
{
    public class LoginViewModel : UserModel
    {
        public RelayCommand LoginCommand { get; set; }
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
                    string url = $"{URLRep.URL}/Usuarios";
                    //UserModel usuariosView = this;
                    var resp = await client.GetAsync($"{url}/login/{nombre}/{passwords}");
                    if (!resp.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Contraseña o usuario incorrecto", "ERROR", MessageBoxButton.OK);
                    }
                    else
                    {
                        MainWindow main = new MainWindow();
                        main.Show();
                        string json = await resp.Content.ReadAsStringAsync();

                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.Strict
                        };

                        var user = JsonSerializer.Deserialize<UserModel>(json,options);

                        UserCache.Id = user.id;
                        UserCache.Nombre = user.nombre;

                        main.miFrame.Navigate(new System.Uri("Views/HomeView.xaml", UriKind.RelativeOrAbsolute));
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
