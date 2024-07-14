namespace Farmacia.Models
{
    public class UserModel : BaseModel
    {
        private double Id;
        private string Nombre;
        private string Email;
        private string Fechanacimiento;
        private string Passwords;
        private string Permisos;
        //private char Permisos;

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
       
        public string permisos
        {
            get
            {
                return Permisos;
                
            }
            set { Permisos = value; OnPropertyChanged(); }
        }


    }
}
