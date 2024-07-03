using CommunityToolkit.Mvvm.Input;
using Farmacia.Models;
using Farmacia.Views;
using System.Net.Http;
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
                    string url = "http://localhost:8080/api/Usuarios";
                    //UserModel usuariosView = this;
                    var resp = await client.GetAsync($"{url}/login/{Name}/{Password}");
                    if (!resp.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Contraseña o usuario incorrecto", "ERROR", MessageBoxButton.OK);
                    }
                    else
                    {
                        MainWindow main = new MainWindow();
                        main.Show();
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
