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
    
    public partial class cp_orden_pago
    {
        public cp_orden_pago()
        {
            this.cp_orden_pago_det = new HashSet<cp_orden_pago_det>();
            this.cp_orden_pago_x_nomina = new HashSet<cp_orden_pago_x_nomina>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPago { get; set; }
        public int IdSucursal { get; set; }
        public string Observacion { get; set; }
        public string IdTipo_op { get; set; }
        public string IdTipo_Persona { get; set; }
        public decimal IdPersona { get; set; }
        public Nullable<decimal> IdEntidad { get; set; }
        public System.DateTime Fecha { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdFormaPago { get; set; }
        public System.DateTime Fecha_Pago { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<int> IdTipoMovi { get; set; }
    
        public virtual cp_orden_pago_formapago cp_orden_pago_formapago { get; set; }
        public virtual cp_orden_pago_tipo cp_orden_pago_tipo { get; set; }
        public virtual ICollection<cp_orden_pago_det> cp_orden_pago_det { get; set; }
        public virtual ICollection<cp_orden_pago_x_nomina> cp_orden_pago_x_nomina { get; set; }
    }
}
