namespace Farmacia.Models
{
    public class DetalleFacturaModel : BaseModel
    {

        private int Det_id;
        private int Det_cantidad;
        private double Det_precio_unitario;
        private double Det_subtotal;
        private double Det_iva;
        private double Det_total;
        private double Producto_id;
        private double Factura_id;

        public int det_id
        {
            get { return Det_id; }
            set { Det_id = value; OnPropertyChanged(); }
        }

        public int det_cantidad
        {
            get { return Det_cantidad; }
            set { Det_cantidad = value; OnPropertyChanged(); }
        }
        public double det_precio_unitario
        {
            get { return Det_precio_unitario; }
            set { Det_precio_unitario = value; OnPropertyChanged(); }
        }
        public double det_subtotal
        {
            get {
                Det_subtotal = Det_precio_unitario + Det_iva;
                Det_subtotal *= Det_cantidad;
                return Det_subtotal; }
            set { Det_subtotal = value; OnPropertyChanged(); }
        }

        public double det_iva
        {
            get { return Det_iva; }
            set { Det_iva = value; OnPropertyChanged(); }
        }

        public double det_total
        {
            get {
                Det_total = Det_subtotal + Det_iva;
                Det_total *= Det_cantidad;
                return Det_total; }
            set { Det_total = value; OnPropertyChanged(); }
        }
        public double producto_id
        {
            get { return Producto_id; }
            set { Producto_id = value; OnPropertyChanged(); }
        }
        public double factura_id
        {
            get { return Factura_id; }
            set { Factura_id = value; OnPropertyChanged(); }
        }

    }
}
