using Farmacia.ViewModel;
using Farmacia.Views.Screens;
using System.Windows.Controls;

namespace Farmacia.Views
{
    /// <summary>
    /// Lógica de interacción para VentasView.xaml
    /// </summary>
    public partial class VentasView : Page
    {
        public IEntityView entityView {  get; set; }
        public VentasView()
        {
            InitializeComponent();
            DataContext = new VentasViewModel();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            ListaProductos listaProductos = new ListaProductos(entityView);
            listaProductos.Show();
        }
    }
}
