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
    
    public partial class VWROL_011
    {
        public int IdEmpresa { get; set; }
        public int IdHorasExtras { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public decimal IdEmpleado { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public Nullable<System.TimeSpan> time_entrada1 { get; set; }
        public Nullable<System.TimeSpan> time_entrada2 { get; set; }
        public Nullable<System.TimeSpan> time_salida1 { get; set; }
        public Nullable<System.TimeSpan> time_salida2 { get; set; }
        public double hora_extra25 { get; set; }
        public double hora_extra50 { get; set; }
        public double hora_extra100 { get; set; }
        public double Valor25 { get; set; }
        public double Valor50 { get; set; }
        public double Valor100 { get; set; }
        public double Sueldo_base { get; set; }
        public double hora_atraso { get; set; }
        public double hora_temprano { get; set; }
        public double hora_trabajada { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionProcesoNomina { get; set; }
        public string ca_descripcion { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_nombreCompleto { get; set; }
    }
}
