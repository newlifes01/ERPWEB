//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ro_prestamo_detalle
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public int NumCuota { get; set; }
        public double SaldoInicial { get; set; }
        public double TotalCuota { get; set; }
        public double Saldo { get; set; }
        public System.DateTime FechaPago { get; set; }
        public string EstadoPago { get; set; }
        public bool Estado { get; set; }
        public string Observacion_det { get; set; }
        public int IdNominaTipoLiqui { get; set; }
    
        public virtual ro_prestamo ro_prestamo { get; set; }
    }
}
