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
    
    public partial class ba_Conciliacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ba_Conciliacion()
        {
            this.ba_Conciliacion_det_IngEgr = new HashSet<ba_Conciliacion_det_IngEgr>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion { get; set; }
        public int IdBanco { get; set; }
        public int IdPeriodo { get; set; }
        public System.DateTime co_Fecha { get; set; }
        public string IdEstado_Concil_Cat { get; set; }
        public double co_SaldoContable_MesAnt { get; set; }
        public double co_totalIng { get; set; }
        public double co_totalEgr { get; set; }
        public double co_SaldoContable_MesAct { get; set; }
        public double co_SaldoBanco_EstCta { get; set; }
        public double co_SaldoBanco_anterior { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuario_Anu { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public string co_Observacion { get; set; }
    
        public virtual ba_Banco_Cuenta ba_Banco_Cuenta { get; set; }
        public virtual ba_Catalogo ba_Catalogo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ba_Conciliacion_det_IngEgr> ba_Conciliacion_det_IngEgr { get; set; }
    }
}
