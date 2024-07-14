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
    /// Lógica de interacción para ManipularUser.xaml
    /// </summary>
    public partial class ManipularUser : Window
    {
        private readonly IEntityView _entityView;
        private readonly UsuariosViewModel _usersViewModel;
        public static ManipularUser Current { get; private set; }
        
        public ManipularUser(IEntityView entity)
        {
            _entityView = entity;
            _usersViewModel = new UsuariosViewModel(entity);
            InitializeComponent();
            DataContext = _usersViewModel;
            Current = this;
            box_permiso.Items.Add("Administrador");
            box_permiso.Items.Add("Empleado");
        }

        public ManipularUser(IEntityView entityView, UserModel user)
        {
            _entityView = entityView;
            _usersViewModel = new UsuariosViewModel(entityView);
            InitializeComponent();
            DataContext = _usersViewModel;
            Current = this;
            lbl_nombre.Text = user.nombre;
            lbl_email.Text = user.email;
            lbl_password.Text = user.passwords;
            box_permiso.Text = user.permisos.ToString();
            box_permiso.Items.Add("Administrador");
            box_permiso.Items.Add("Empleado");
            /////////////

        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = datePicker.SelectedDate;
            if (selectedDate.HasValue)
            {
                string formattedDate = selectedDate.Value.ToString("dd/MM/yy");
                _usersViewModel.fechanacimiento = formattedDate;
            }
        }
    }
}
