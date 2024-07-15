using Farmacia.Models;
using Farmacia.ViewModel;
using System.Windows.Controls;

namespace Farmacia.Views
{
    /// <summary>
    /// Lógica de interacción para ClientesView.xaml
    /// </summary>
    public partial class ClientesView : Page
    {
        private ClientesViewModel viewModel;
        public IEntityView entity {  get; set; }
        public ClientesView()
        {
            InitializeComponent();
            viewModel = new ClientesViewModel(entity);
            DataContext = viewModel;
        }

    }
}
