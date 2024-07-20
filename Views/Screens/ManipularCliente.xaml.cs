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
    /// Lógica de interacción para ManipularCliente.xaml
    /// </summary>
    public partial class ManipularCliente : Window
    {

        public IEntityView entityView {  get; set; }
        public readonly ClientesViewModel view;
        public static ManipularCliente Current { get; private set; }
        public ManipularCliente(IEntityView entityView)
        {
            InitializeComponent();
            view = new ClientesViewModel(entityView);
            DataContext = view;
            this.entityView = entityView;
            Current = this;
        }

        public ManipularCliente(IEntityView entityView, cliente client)
        {
            InitializeComponent();
            view = new ClientesViewModel(entityView);
            DataContext = view;
            this.entityView = entityView;
            Current = this;

        }

        private void combo_tipo_cliente_Loaded(object sender, RoutedEventArgs e)
        {
            combo_tipo_cliente.Items.Add("Comprador");
            combo_tipo_cliente.Items.Add("Vendedor");
        }
    }
}
