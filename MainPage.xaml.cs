using Farmacia.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Farmacia
{
    /// <summary>
    /// Lógica de interacción para MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        private readonly LoginViewModel loginViewModel;
        public static MainPage Current { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            loginViewModel = new LoginViewModel();
            Current = this;
            DataContext = loginViewModel;
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox passwordBox)
            {
                loginViewModel.Password = passwordBox.Password;
            }
        }
    }
}
