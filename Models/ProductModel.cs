using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    public class ProductModel
    {
        private int id;
        private string codigo_producto;
        private string nombre;
        private double precio;
        private int stock;
        private Taxes iva;

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
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public Taxes Iva
        {
            get { return iva; }
            set { iva = value; }
        }
    }
}
