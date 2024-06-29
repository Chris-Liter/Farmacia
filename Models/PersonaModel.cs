using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    internal class PersonaModel
    {
        private int cli_id;
        private string cli_cedula;
        private string cli_nombres;
        private string cli_apellidos;
        private string cli_direccion;
        private string cli_telefono;
        private string cli_correo;
        private TypePerson typePerson;

        public int Cli_id
        {
            get { return cli_id; }
            set { cli_id = value;  }
        }
        public string Cli_cedula
        {
            get { return cli_cedula; }
            set { cli_cedula = value;  }
        }
        public string Cli_nombres
        {
            get { return cli_nombres; }
            set
            {
                cli_nombres = value;
                
            }
        }
        public string Cli_apellidos
        {
            get { return cli_apellidos; }
            set { cli_apellidos = value;  }
        }
        public string Cli_direccion
        {
            get { return cli_direccion; }
            set { cli_direccion = value;  }
        }
        public string Cli_telefono
        {
            get { return cli_telefono; }
            set { cli_telefono = value;  }
        }
        public string Cli_correo
        {
            get { return cli_correo; }
            set { cli_correo = value;  }
        }
        public TypePerson Type_person
        {
            get { return typePerson; }
            set { typePerson = value;  }
        }
    }
}
