using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    public enum Taxes
    {
        IVA0,
        IVA15
    }
    public enum TypePerson
    {
        proveedor,
        comprador
    }
    public enum Permisos
    {
        empleado,
        administrador
    }
    public enum EstadoFactura
    {
        anulado,
        activo,
        compra
    }
}
