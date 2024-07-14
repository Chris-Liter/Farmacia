using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia.Models
{
    internal class FacturaModel: BaseModel
    {
        private int Fac_id;
        private int Fac_tipo;
        private int Fac_numero;
        private string? Fac_fecha;
        private double? Fac_subtotal;
        private double? Fac_total;
        private double? Fac_total_iva;
        private int Id_cliente;
        private int Id_usuario;

        public int fac_id
        {
            get { return Fac_id; }
            set { Fac_id = value; OnPropertyChanged(); }
        }
        public int fac_tipo {
            get { return Fac_tipo; }
            set { Fac_tipo = value; OnPropertyChanged(); }
        }
        public int fac_numero {  
            get { return Fac_numero; }
            set { Fac_numero = value; OnPropertyChanged(); }
        }
        public string fac_fecha {
            get { return Fac_fecha; }
            set { Fac_fecha = value; OnPropertyChanged(); }
        }
        public double? fac_subtotal {
            get { return Fac_subtotal; }
            set { Fac_subtotal = value; OnPropertyChanged(); }
        }
        public double? fac_total_iva {
            get { return Fac_total_iva; }
            set { Fac_total_iva = value; OnPropertyChanged(); }
        }
        public double? fac_total {
            get { return Fac_total; }
            set { Fac_total = value;OnPropertyChanged(); }
        }
        public int id_cliente {
            get { return Id_cliente; } 
            set { Id_cliente = value; OnPropertyChanged(); }
        }
        public int id_usuario { 
            get { return Id_usuario; }
            set { Id_usuario = value; OnPropertyChanged(); }
        }

    }
}
