//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwfa_CambioProductoDet_facturas
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int Secuencia { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public double vt_cantidad { get; set; }
        public string vt_NumFactura { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }
    }
}
