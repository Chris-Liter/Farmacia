using Farmacia.Models;
using Farmacia.ViewModel;
using System.Windows;

namespace Farmacia.Views.Screens
{
    /// <summary>
    /// Lógica de interacción para ManipularInventory.xaml
    /// </summary>
    public partial class ManipularInventory : Window
    {
        private readonly InventoryViewModel inventario;
        public static ManipularInventory Current {  get; set; }
        public ManipularInventory()
        {
            inventario = new InventoryViewModel();
            Current = this;  
            InitializeComponent();
            DataContext = inventario;
        }
        public ManipularInventory(ProductsModel product)
        {
            inventario = new InventoryViewModel();
            InitializeComponent();
            Current = this;
            DataContext = inventario;
            inventario.codigo_producto = product.codigo_producto;
            inventario.nombre = product.nombre;
            inventario.precio = product.precio;
            inventario.stock = product.stock;
            inventario.iva = product.iva;
            inventario.SelectedProduct = product;
        }

    }
}
