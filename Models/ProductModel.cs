﻿namespace Farmacia.Models
{
    public class ProductModel
    {
        private int id;
        private string codigo_producto;
        private string nombre;
        private double precio;
        private double stock;
        private double iva;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
        public string CodigoProducto
        {
            get
            {
                return codigo_producto;
            }
            set { codigo_producto = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public double Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }
    }

    public class ProductsModel : BaseModel
    {
        public double id { get; set; }
        public string codigo_producto { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public double stock { get; set; }
        public double iva { get; set; }
    }

}
