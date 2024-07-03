using Farmacia.Views.Screens;
using System.Windows;
using System.Windows.Controls;

namespace Farmacia.Views
{
    /// <summary>
    /// Lógica de interacción para InventarioView.xaml
    /// </summary>
    public partial class InventarioView : Page
    {
        private ManipularInventory manipularInventory;
        public InventarioView()
        {
            manipularInventory = new ManipularInventory();
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (manipularInventory.IsVisible == false)
            {
                manipularInventory = new ManipularInventory();
                manipularInventory.Show();
            }
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
