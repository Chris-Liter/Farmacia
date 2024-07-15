using Farmacia.ViewModel;
using Farmacia.Views.Screens;
using System.Windows.Controls;
using System.Windows.Input;

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

        private async void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ListaProductos listaProductos = new ListaProductos(entityView);
                
                listaProductos.Show();
                Thread.Sleep(1000);
                string busqueda = lbl_busqueda.Text;
                await listaProductos.Aviso(busqueda);

                //entityView.update();
            }
        }
    }
}
