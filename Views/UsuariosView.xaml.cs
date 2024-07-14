using Farmacia.ViewModel;
using System.Windows.Controls;

namespace Farmacia.Views
{
    /// <summary>
    /// Lógica de interacción para UsuariosView.xaml
    /// </summary>
    public partial class UsuariosView : Page
    {
        //private readonly UsuariosViewModel viewModel;
        private IEntityView entityView {  get; set; }
        public UsuariosView()
        {
            InitializeComponent();
            //viewModel = new UsuariosViewModel(entityView);
            DataContext = new UsuariosViewModel(entityView);
        }
    }
}
