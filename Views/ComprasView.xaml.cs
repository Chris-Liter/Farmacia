using Farmacia.ViewModel;
using Farmacia.Views.Screens;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace Farmacia.Views
{
    /// <summary>
    /// Lógica de interacción para ComprasView.xaml
    /// </summary>
    public partial class ComprasView : Page
    {
        public IEntityView entityView { get; set; }
        public readonly ComprasViewModel compras;
        public ComprasView()
        {
            InitializeComponent();
            compras = new ComprasViewModel();
            DataContext = compras;
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
                Thread.Sleep(500);
                string busqueda = lbl_busqueda.Text;
                await listaProductos.Aviso(busqueda);

                //entityView.update();
            }
        }

        

        private async void Cedula_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                ClientesViewModel model = new ClientesViewModel(entityView);
                if(await model.Search(Cedula.Text) != null)
                {
                    compras.Person = await model.Search(Cedula.Text);
                    Nombre.Text = compras.Person.cli_nombres;
                    Apellido.Text = compras.Person.cli_apellidos;
                    Correo.Text = compras.Person.cli_correo;
                    Telefono.Text = compras.Person.cli_telefono;
                    Direccion.Text = compras.Person.cli_direccion;

                }

            }
        }
    }
}
