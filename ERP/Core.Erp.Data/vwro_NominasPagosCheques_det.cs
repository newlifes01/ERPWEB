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
    
    public partial class vwro_NominasPagosCheques_det
    {
        public int IdEmpresa { get; set; }
        public int IdTransaccion { get; set; }
        public int Secuencia { get; set; }
        public int IdSucursal { get; set; }
        public Nullable<decimal> IdEmpleado { get; set; }
        public string Observacion { get; set; }
        public double Valor { get; set; }
        public int IdEmpresa_op { get; set; }
        public decimal IdOrdenPago { get; set; }
        public string em_codigo { get; set; }
        public string em_tipoCta { get; set; }
        public string em_NumCta { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
        public decimal IdPersona { get; set; }
    }
}
