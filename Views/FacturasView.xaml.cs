using Farmacia.ViewModel;
using System.Windows.Controls;

namespace Farmacia.Views
{
    /// <summary>
    /// Lógica de interacción para FacturasView.xaml
    /// </summary>
    public partial class FacturasView : Page
    {
        public readonly IEntityView _comprasViewModel;
        private IEntityView entity {  get; set; }
        public FacturasView()
        {
            InitializeComponent();
            _comprasViewModel = new ComprasViewModel(entity);
            DataContext = _comprasViewModel;
        }
    }
}
