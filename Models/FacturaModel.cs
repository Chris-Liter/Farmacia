using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Models
{
    internal class FacturaModel
    {
        private int fac_id;
        private EstadoFactura invoiceState;
        private int fac_numero;
        private DateTime fac_fecha;
        private int tr_cli_id;
        private int tr_usu_id;
        private double? fac_subtotal;
        private double? fac_total;
        private double? fac_total_iva;
        private PersonaModel person;
        private ObservableCollection<DetalleFacturaModel> invoiceDetailModels;
        private EstadoFactura facTipo;

        //public void AddDetail(DetalleFacturaModel item)
        //{
        //    InvoiceDetailModels.Add(item);
        //    UpdateValues();
        //}

        
        //public ObservableCollection<InvoiceDetailModel> InvoiceDetailModels
        //{
        //    get { return invoiceDetailModels; }
        //    set { invoiceDetailModels = value; OnPropertyChange(); }
        //}
        //public PersonModel Person
        //{
        //    get { return person; }
        //    set { person = value; OnPropertyChange(); }
        //}
        //public int Fac_id
        //{
        //    get { return fac_id; }
        //    set { fac_id = value; OnPropertyChange(); }
        //}

        //public InvoiceState FacTipo
        //{
        //    get { return facTipo; }
        //    set { facTipo = value; OnPropertyChange(); }
        //}
        //public int Fac_numero
        //{
        //    get { return fac_numero; }
        //    set { fac_numero = value; OnPropertyChange(); }
        //}
        //public DateTime Fac_fecha
        //{
        //    get { return fac_fecha; }
        //    set { fac_fecha = value; OnPropertyChange(); }
        //}
        //public double? Fac_subtotal
        //{
        //    get
        //    {
        //        if (fac_subtotal == 0 || fac_subtotal == null)
        //            return Math.Round(InvoiceDetailModels.Sum(datos => datos.Det_subtotal), 2);
        //        else
        //            return fac_subtotal;
        //    }
        //    set
        //    {
        //        fac_subtotal = value;
        //        OnPropertyChange();
        //    }

        //}
        //public double? Fac_total_iva
        //{
        //    get
        //    {
        //        if (fac_total_iva == 0 || fac_total_iva == null)
        //            return Math.Round(InvoiceDetailModels.Sum(datos => datos.Det_iva), 2);
        //        else
        //            return fac_total_iva;
        //    }
        //    set
        //    {
        //        fac_total_iva = value;
        //        OnPropertyChange();
        //    }
        //}
        //public double? Fac_total
        //{
        //    get
        //    {
        //        if (fac_total == 0 || fac_total == null)
        //            return Fac_total_iva + Fac_subtotal;
        //        else
        //            return fac_total;
        //    }
        //    set
        //    {
        //        fac_total = value;
        //        OnPropertyChange();
        //    }
        //}
        ////return Fac_total_iva + Fac_subtotal;
        //public int Tr_cli_id
        //{
        //    get { return tr_cli_id; }
        //    set { tr_cli_id = value; OnPropertyChange(); }
        //}
        //public int Tr_usu_id
        //{
        //    get { return tr_usu_id; }
        //    set { tr_usu_id = value; OnPropertyChange(); }
        //}
        //public InvoiceState Invoice_state
        //{
        //    get { return invoiceState; }
        //    set { invoiceState = value; OnPropertyChange(); }
        //}
    }
}
