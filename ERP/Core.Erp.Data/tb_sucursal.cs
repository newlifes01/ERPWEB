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
    
    public partial class tb_sucursal
    {
        public tb_sucursal()
        {
            this.tb_bodega = new HashSet<tb_bodega>();
            this.tb_sucursal_FormaPago_x_fa_NivelDescuento = new HashSet<tb_sucursal_FormaPago_x_fa_NivelDescuento>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string codigo { get; set; }
        public string Su_Descripcion { get; set; }
        public string Su_CodigoEstablecimiento { get; set; }
        public string Su_Ruc { get; set; }
        public string Su_JefeSucursal { get; set; }
        public string Su_Telefonos { get; set; }
        public string Su_Direccion { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }
        public bool Es_establecimiento { get; set; }
        public string IdCtaCble_cxp { get; set; }
        public string IdCtaCble_vtaIVA0 { get; set; }
        public string IdCtaCble_vtaIVA { get; set; }
    
        public virtual ICollection<tb_bodega> tb_bodega { get; set; }
        public virtual tb_empresa tb_empresa { get; set; }
        public virtual ICollection<tb_sucursal_FormaPago_x_fa_NivelDescuento> tb_sucursal_FormaPago_x_fa_NivelDescuento { get; set; }
    }
}
