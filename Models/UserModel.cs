using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    public class UserModel
    {
        private int id;
        private string name;
        private string password;
        private Permisos permiso;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public Permisos Permiso
        {
            get { return permiso; }
            set { permiso = value; }
        }


    }
}
