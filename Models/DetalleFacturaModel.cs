namespace Farmacia.Models
{
    internal class DetalleFacturaModel:BaseModel
    {

        private int Det_id;
        private string Code;
        private string Name;
        private int Det_cantidad;
        private double Det_precio_unitario;
        private string Pro_tax;
        private int Tr_prod_id;
        private int Tr_fac_numero;
        private int Tr_fac_tipo;

        public string pro_tax
        {
            get { return Pro_tax; }
            set { Pro_tax = value; OnPropertyChanged(); }

        }

        public int det_id
        {
            get { return Det_id; }
            set { Det_id = value; OnPropertyChanged(); }

        }
        public int det_cantidad
        {
            get { return Det_cantidad; }
            set
            {
                if (value == 0)
                {
                    Det_cantidad = 1;
                }
                else
                {
                    Det_cantidad = value;
                }
                OnPropertyChanged();
                OnPropertyChanged("Det_subtotal"); ;
            }
        }
        public double det_precio_Unitario
        {
            get { return Det_precio_unitario; }
            set { Det_precio_unitario = value; OnPropertyChanged(); }
        }

        public double det_subtotal
        {
            get { return Math.Round(det_precio_Unitario * det_cantidad, 2); }
        }

        public double det_iva
        {
            get
            {
                if (pro_tax == "0.15")
                    return det_subtotal * 0.15;
                return 0;
            }
        }
        public double det_total
        {
            get { return det_subtotal + det_iva; }
        }
        public int tr_prod_id
        {
            get { return Tr_prod_id; }
            set { Tr_prod_id = value; OnPropertyChanged(); }
        }
        public int tr_fac_numero
        {
            get { return Tr_fac_numero; }
            set { Tr_fac_numero = value; OnPropertyChanged(); }
        }
        public int tr_fac_tipo
        {
            get { return Tr_fac_tipo; }
            set { tr_fac_tipo = value; OnPropertyChanged(); }
        }
        public string code
        {
            get { return Code; }
            set { Code = value; OnPropertyChanged(); }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; OnPropertyChanged(); }
        }
    }
}
