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
    
    public partial class ro_cargo
    {
        public ro_cargo()
        {
            this.ro_Acta_Finiquito = new HashSet<ro_Acta_Finiquito>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdCargo { get; set; }
        public string ca_descripcion { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotivoAnulacion { get; set; }
        public Nullable<bool> considera_pago_utilidad { get; set; }
    
        public virtual ICollection<ro_Acta_Finiquito> ro_Acta_Finiquito { get; set; }
    }
}
