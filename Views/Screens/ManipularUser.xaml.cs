using Farmacia.Models;
using Farmacia.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public IEntityView _entityView {  get; set; }
        private readonly UsuariosViewModel _usersViewModel;
        public static ManipularUser Current { get; private set; }
        
        public ManipularUser(IEntityView entity)
        {
            _entityView = entity;
            _usersViewModel = new UsuariosViewModel(entity);
            InitializeComponent();
            DataContext = _usersViewModel;
            Current = this;
        }

        public ManipularUser(IEntityView entityView, UserModel user)
        {
            _entityView = entityView;
            _usersViewModel = new UsuariosViewModel(entityView);
            InitializeComponent();
            DataContext = _usersViewModel;
            Current = this;
            _usersViewModel.nombre = user.nombre;
            _usersViewModel.email = user.email;
            _usersViewModel.passwords = user.passwords;

            DateTime parsedDate;
            if (DateTime.TryParseExact(user.fechanacimiento, "dd/MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                datePicker.SelectedDate = parsedDate;


            if (user.permisos == "Administrador")
                box_permiso.SelectedIndex = 0;
            else
                box_permiso.SelectedIndex = 1;
            /////////////
            _usersViewModel.UserSelected = user;

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

        private void box_permiso_Loaded(object sender, RoutedEventArgs e)
        {

            box_permiso.Items.Add("Administrador");
            box_permiso.Items.Add("Empleado");

            box_permiso.SelectedIndex = 2;
        }
    }
}
