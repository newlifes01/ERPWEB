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
    
    public partial class VWROL_002_detallle_prestamos
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public System.DateTime FechaPago { get; set; }
        public string Observacion_det { get; set; }
        public int NumCuota { get; set; }
        public int NumCuotas { get; set; }
        public double TotalCuota { get; set; }
        public bool Estado { get; set; }
        public string ru_descripcion { get; set; }
    }
}
