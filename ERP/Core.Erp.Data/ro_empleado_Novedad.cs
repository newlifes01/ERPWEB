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
    
    public partial class ro_empleado_Novedad
    {
        public ro_empleado_Novedad()
        {
            this.ro_empleado_novedad_det = new HashSet<ro_empleado_novedad_det>();
            this.ro_EmpleadoNovedadCargaMasiva_det = new HashSet<ro_EmpleadoNovedadCargaMasiva_det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdNovedad { get; set; }
        public decimal IdEmpleado { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string Observacion { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public System.DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Estado { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual ICollection<ro_empleado_novedad_det> ro_empleado_novedad_det { get; set; }
        public virtual ro_Nomina_Tipoliqui ro_Nomina_Tipoliqui { get; set; }
        public virtual ro_empleado ro_empleado { get; set; }
        public virtual ro_empleado ro_empleado1 { get; set; }
        public virtual ICollection<ro_EmpleadoNovedadCargaMasiva_det> ro_EmpleadoNovedadCargaMasiva_det { get; set; }
    }
}
