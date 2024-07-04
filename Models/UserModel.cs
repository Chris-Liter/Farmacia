namespace Farmacia.Models
{
    public class UserModel : BaseModel
    {
        private double Id;
        private string Nombre;
        private string Email;
        private string Passwords;
        private PermisosUsuario Permiso;
        private char Permisos;
        private string Fechanacimiento;

        public double id
        {
            get { return Id; }
            set { Id = value; OnPropertyChanged(); }
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; OnPropertyChanged(); }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; OnPropertyChanged(); }
        }
        public string passwords
        {
            get { return Passwords; }
            set { Passwords = value; OnPropertyChanged(); }
        }
        public string fechanacimiento
        {
            get { return Fechanacimiento; }
            set { Fechanacimiento = value; OnPropertyChanged(); }
        }
        public char permisos
        {
            get { return Permisos; }
            set { Permisos = value; OnPropertyChanged(); } 
        }

        public PermisosUsuario permiso
        {
            get { if (permisos == 1)
                {
                    return PermisosUsuario.administrador;
                }
                else
                {
                    return PermisosUsuario.empleado;
                }
            }
            set { if (permisos == 1) {
                    Permiso = PermisosUsuario.administrador;
                }
                else
                {
                    Permiso = PermisosUsuario.empleado;
                }
                OnPropertyChanged(); }
        }


    }
}
