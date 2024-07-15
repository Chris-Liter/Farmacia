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

namespace Farmacia.Views.Screens
{
    /// <summary>
    /// Lógica de interacción para ListaProductos.xaml
    /// </summary>
    public partial class ListaProductos : Window
    {
        public readonly IEntityView entityView;
        private InventoryViewModel inventoryViewModel {  get; set; }
        public ListaProductos(IEntityView entityView)
        {
            this.entityView = entityView;
            InitializeComponent();
            inventoryViewModel = new InventoryViewModel(entityView);
            DataContext = inventoryViewModel;
        }

        public async Task Aviso(string busqueda)
        {
           await inventoryViewModel.Search(busqueda);
        }
    }
}
