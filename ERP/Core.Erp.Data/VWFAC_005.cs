//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class VWFAC_005
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public decimal IdCliente { get; set; }
        public Nullable<int> IdContacto { get; set; }
        public string NomCliente { get; set; }
        public string NomContacto { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public double SubtotalIVA0 { get; set; }
        public double SubtotalIVA { get; set; }
        public double vt_iva { get; set; }
        public double Total { get; set; }
        public double VRetenIVA { get; set; }
        public double VRetenFTE { get; set; }
        public double ValorACobrar { get; set; }
        public double VCobrado { get; set; }
        public double Saldo { get; set; }
        public string TipoDocumento { get; set; }
        public Nullable<bool> EsExportacion { get; set; }
        public string Su_Descripcion { get; set; }
        public string Su_CodigoEstablecimiento { get; set; }
    }
}