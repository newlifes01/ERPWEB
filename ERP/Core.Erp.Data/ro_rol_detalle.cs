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
    
    public partial class ro_rol_detalle
    {
        public int IdEmpresa { get; set; }
        public decimal IdRol { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdRubro { get; set; }
        public int Orden { get; set; }
        public double Valor { get; set; }
        public Nullable<bool> rub_visible_reporte { get; set; }
        public string Observacion { get; set; }
        public int IdSucursal { get; set; }
    
        public virtual ro_empleado ro_empleado { get; set; }
        public virtual ro_rubro_tipo ro_rubro_tipo { get; set; }
        public virtual ro_rol ro_rol { get; set; }
    }
}
