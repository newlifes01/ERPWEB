//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwfa_factura_detalle
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int Secuencia { get; set; }
        public string pr_codigo { get; set; }
        public string pr_codigo2 { get; set; }
        public string pr_descripcion { get; set; }
        public string vt_detallexItems { get; set; }
        public double vt_cantidad { get; set; }
        public Nullable<decimal> vt_Precio { get; set; }
        public double vt_PorDescUnitario { get; set; }
        public Nullable<decimal> vt_DescUnitario { get; set; }
        public Nullable<decimal> vt_PrecioFinal { get; set; }
        public Nullable<decimal> vt_Subtotal { get; set; }
        public Nullable<decimal> vt_iva { get; set; }
        public Nullable<decimal> vt_total { get; set; }
        public double vt_por_iva { get; set; }
    }
}
