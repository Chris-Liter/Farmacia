namespace Farmacia.Models
{
    internal class DetalleFacturaModel:BaseModel
    {

        private int det_id;
        private string code;
        private string name;
        private int det_cantidad;
        private double det_precio_unitario;
        private Taxes pro_tax;
        private int tr_prod_id;
        private int tr_fac_numero;
        private int tr_fac_tipo;

        public Taxes Pro_tax
        {
            get { return pro_tax; }
            set { pro_tax = value; OnPropertyChanged(); }

        }

        public int Det_id
        {
            get { return det_id; }
            set { det_id = value; OnPropertyChanged(); }

        }
        public int Det_cantidad
        {
            get { return det_cantidad; }
            set
            {
                if (value == 0)
                {
                    det_cantidad = 1;
                }
                else
                {
                    det_cantidad = value;
                }
                OnPropertyChanged();
                OnPropertyChanged("Det_subtotal"); ;
            }
        }
        public double Det_precio_Unitario
        {
            get { return det_precio_unitario; }
            set { det_precio_unitario = value; OnPropertyChanged(); }
        }

        public double Det_subtotal
        {
            get { return Math.Round(Det_precio_Unitario * Det_cantidad, 2); }
        }

        public double Det_iva
        {
            get
            {
                if (Pro_tax == Taxes.IVA15)
                    return Det_subtotal * 0.15;
                return 0;
            }
        }
        public double Det_total
        {
            get { return Det_subtotal + Det_iva; }
        }
        public int Tr_prod_id
        {
            get { return tr_prod_id; }
            set { tr_prod_id = value; OnPropertyChanged(); }
        }
        public int Tr_fac_numero
        {
            get { return tr_fac_numero; }
            set { tr_fac_numero = value; OnPropertyChanged(); }
        }
        public int Tr_fac_tipo
        {
            get { return tr_fac_tipo; }
            set { tr_fac_tipo = value; OnPropertyChanged(); }
        }
        public string Code
        {
            get { return code; }
            set { code = value; OnPropertyChanged(); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }
    }
}
