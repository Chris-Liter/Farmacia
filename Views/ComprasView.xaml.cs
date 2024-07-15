using Farmacia.ViewModel;
using Farmacia.Views.Screens;
using System.Windows.Controls;
using System.Windows.Input;

namespace Farmacia.Views
{
    /// <summary>
    /// Lógica de interacción para ComprasView.xaml
    /// </summary>
    public partial class ComprasView : Page
    {
        public IEntityView entityView { get; set; }

        public ComprasView()
        {
            InitializeComponent();
            DataContext = new ComprasViewModel();
            DateTime data = DateTime.Now;
            pck_fecha.SelectedDate = data;
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
