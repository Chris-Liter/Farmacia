﻿namespace Farmacia.Models
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
        Empleado = 0,
        Administrador = 1
    }
    public enum EstadoFactura
    {
        anulado,
        activo,
        compra
    }
}
