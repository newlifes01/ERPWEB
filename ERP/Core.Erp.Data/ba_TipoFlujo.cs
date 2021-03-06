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
    
    public partial class ba_TipoFlujo
    {
        public ba_TipoFlujo()
        {
            this.ba_Cbte_Ban = new HashSet<ba_Cbte_Ban>();
            this.ba_Cbte_Ban_x_ba_TipoFlujo = new HashSet<ba_Cbte_Ban_x_ba_TipoFlujo>();
            this.ba_TipoFlujo1 = new HashSet<ba_TipoFlujo>();
            this.ba_TipoFlujo_PlantillaDet = new HashSet<ba_TipoFlujo_PlantillaDet>();
            this.ba_TipoFlujo_Movimiento = new HashSet<ba_TipoFlujo_Movimiento>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdTipoFlujo { get; set; }
        public Nullable<decimal> IdTipoFlujoPadre { get; set; }
        public string Descricion { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public string Tipo { get; set; }
        public string cod_flujo { get; set; }
    
        public virtual ICollection<ba_Cbte_Ban> ba_Cbte_Ban { get; set; }
        public virtual ICollection<ba_Cbte_Ban_x_ba_TipoFlujo> ba_Cbte_Ban_x_ba_TipoFlujo { get; set; }
        public virtual ICollection<ba_TipoFlujo> ba_TipoFlujo1 { get; set; }
        public virtual ba_TipoFlujo ba_TipoFlujo2 { get; set; }
        public virtual ICollection<ba_TipoFlujo_PlantillaDet> ba_TipoFlujo_PlantillaDet { get; set; }
        public virtual ICollection<ba_TipoFlujo_Movimiento> ba_TipoFlujo_Movimiento { get; set; }
    }
}
