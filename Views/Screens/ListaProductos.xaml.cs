using Farmacia.Models;
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
            //Current = this;
        }

        public async Task Aviso(string busqueda)
        {
           await inventoryViewModel.Search(busqueda);
        }

        private async void ItemsDatagrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ProductsModel producto = ItemsDatagrid.SelectedItem as ProductsModel;
            var valor = ComprasView.Instance;
            producto.stock = 1;
            valor.compras.Productos.Add(producto);
            decimal total = await valor.compras.CalcularTotal();
            decimal iva = await valor.compras.CalcularIva();
            decimal subtotal = await valor.compras.CalcularSubTotal();
            valor.Total.Text = total.ToString();
            valor.Iva.Text = iva.ToString();
            valor.Subtotal.Text = subtotal.ToString();
            Close();          
        }
    }
}
