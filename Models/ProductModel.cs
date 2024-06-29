using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    internal class ProductModel
    {
        private int pro_id;
        private string pro_nombre;
        private string pro_codigo;
        private double pro_precio;
        private int pro_stock;
        private Taxes pro_iva;
        private int tr_cat_id;
        private string descripcion;


        public int Pro_id
        {   
            get { return pro_id; }
            set
            {
                pro_id = value;
                
            }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value;  }
        }

        public string Pro_nombre
        {
            get { return pro_nombre; }
            set
            {
                pro_nombre = value;
                
            }
        }

        public string Pro_codigo
        {
            get { return pro_codigo; }
            set
            {
                pro_codigo = value;
                
            }
        }

        public double Pro_precio
        {
            get { return pro_precio; }
            set
            {
                pro_precio = value;
                

            }
        }
        public int Pro_stock
        {
            get { return pro_stock; }
            set
            {
                pro_stock = value;
                

            }
        }
        public Taxes Pro_iva
        {
            get { return pro_iva; }
            set
            {
                pro_iva = value;
                
            }
        }
        public int Tr_cat_id
        {
            get { return tr_cat_id; }
            set {
                tr_cat_id = value;
                
            }
        }
    }
}
