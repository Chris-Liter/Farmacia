namespace Farmacia.Models
{
    public class UserModel : BaseModel
    {
        private int Id;
        private string Nombre;
        private string Email;
        private string Passwords;
        private Permisos Permiso;
        private string Fechanacimiento;

        public int id
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
        public Permisos permiso
        {
            get { return Permiso; }
            set { Permiso = value; OnPropertyChanged(); }
        }


    }
}
