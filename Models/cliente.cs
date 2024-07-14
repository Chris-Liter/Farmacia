using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    class cliente: BaseModel
    {
        private int Cli_id;
        private string Cli_cedula;
        private string Cli_nombres;
        private string Cli_apellidos;
        private string Cli_direccion;
        private string Cli_telefono;
        private string Cli_correo;
        private TypePerson TypePerson;

        public int cli_id
        {
            get { return Cli_id; }
            set { Cli_id = value; OnPropertyChanged(); }
        }
        public string cli_cedula
        {
            get { return Cli_cedula; }
            set { Cli_cedula = value; OnPropertyChanged(); }
        }
        public string cli_nombres
        {
            get { return Cli_nombres; }
            set
            {
                Cli_nombres = value;
                OnPropertyChanged();
            }
        }
        public string cli_apellidos
        {
            get { return Cli_apellidos; }
            set { Cli_apellidos = value; OnPropertyChanged(); }
        }
        public string cli_direccion
        {
            get { return Cli_direccion; }
            set { Cli_direccion = value; OnPropertyChanged(); }
        }
        public string cli_telefono
        {
            get { return Cli_telefono; }
            set { Cli_telefono = value; OnPropertyChanged(); }
        }
        public string cli_correo
        {
            get { return Cli_correo; }
            set { Cli_correo = value; OnPropertyChanged(); }
        }
        public TypePerson type_person
        {
            get { return TypePerson; }
            set { TypePerson = value; OnPropertyChanged(); }
        }
    }
}
