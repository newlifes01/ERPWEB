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
    
    public partial class vwRo_Prestamo
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public decimal IdEmpleado { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public string IdRubro { get; set; }
        public string ru_descripcion { get; set; }
        public decimal IdEmpleado_Aprueba { get; set; }
        public string pe_nombre_apru { get; set; }
        public string pe_apellido_apru { get; set; }
        public string Estado { get; set; }
        public System.DateTime Fecha { get; set; }
        public double MontoSol { get; set; }
        public double TotalCobrado { get; set; }
        public double Valor_pendiente { get; set; }
        public double TasaInteres { get; set; }
        public int NumCuotas { get; set; }
        public System.DateTime Fecha_PriPago { get; set; }
        public string Observacion { get; set; }
        public string Tipo_Calculo { get; set; }
        public string MotiAnula { get; set; }
        public string pe_cedulaRuc { get; set; }
        public int IdTipoPersona { get; set; }
        public decimal IdPersona { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public Nullable<decimal> IdOrdenPago { get; set; }
        public bool descuento_mensual { get; set; }
        public bool descuento_quincena { get; set; }
        public bool descuento_men_quin { get; set; }
    }
}
