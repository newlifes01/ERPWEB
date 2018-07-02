﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities_cuentas_por_pagar : DbContext
    {
        public Entities_cuentas_por_pagar()
            : base("name=Entities_cuentas_por_pagar")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cp_codigo_SRI_tipo> cp_codigo_SRI_tipo { get; set; }
        public virtual DbSet<cp_codigo_SRI> cp_codigo_SRI { get; set; }
        public virtual DbSet<cp_codigo_SRI_x_CtaCble> cp_codigo_SRI_x_CtaCble { get; set; }
        public virtual DbSet<cp_proveedor_clase> cp_proveedor_clase { get; set; }
        public virtual DbSet<cp_proveedor> cp_proveedor { get; set; }
        public virtual DbSet<vwcp_proveedor_consulta> vwcp_proveedor_consulta { get; set; }
        public virtual DbSet<cp_orden_giro> cp_orden_giro { get; set; }
        public virtual DbSet<cp_pagos_sri> cp_pagos_sri { get; set; }
        public virtual DbSet<cp_cuotas_x_doc> cp_cuotas_x_doc { get; set; }
        public virtual DbSet<cp_cuotas_x_doc_det> cp_cuotas_x_doc_det { get; set; }
        public virtual DbSet<vwcp_codigo_SRI> vwcp_codigo_SRI { get; set; }
        public virtual DbSet<cp_TipoDocumento> cp_TipoDocumento { get; set; }
        public virtual DbSet<cp_parametros> cp_parametros { get; set; }
        public virtual DbSet<cp_orden_pago> cp_orden_pago { get; set; }
        public virtual DbSet<cp_orden_pago_det> cp_orden_pago_det { get; set; }
        public virtual DbSet<cp_orden_pago_formapago> cp_orden_pago_formapago { get; set; }
        public virtual DbSet<cp_orden_pago_tipo_x_empresa> cp_orden_pago_tipo_x_empresa { get; set; }
        public virtual DbSet<cp_orden_pago_tipo> cp_orden_pago_tipo { get; set; }
        public virtual DbSet<cp_retencion> cp_retencion { get; set; }
        public virtual DbSet<cp_retencion_det> cp_retencion_det { get; set; }
        public virtual DbSet<cp_retencion_x_ct_cbtecble> cp_retencion_x_ct_cbtecble { get; set; }
        public virtual DbSet<vwcp_orden_giro> vwcp_orden_giro { get; set; }
        public virtual DbSet<vwcp_retencion> vwcp_retencion { get; set; }
        public virtual DbSet<cp_orden_pago_estado_aprob> cp_orden_pago_estado_aprob { get; set; }
        public virtual DbSet<vwcp_nota_DebCre> vwcp_nota_DebCre { get; set; }
        public virtual DbSet<vwcp_orden_pago> vwcp_orden_pago { get; set; }
        public virtual DbSet<vwcp_orden_giro_x_pagar> vwcp_orden_giro_x_pagar { get; set; }
        public virtual DbSet<cp_orden_pago_cancelaciones> cp_orden_pago_cancelaciones { get; set; }
        public virtual DbSet<cp_nota_DebCre> cp_nota_DebCre { get; set; }
        public virtual DbSet<cp_orden_giro_pagos_sri> cp_orden_giro_pagos_sri { get; set; }
        public virtual DbSet<cp_pais_sri> cp_pais_sri { get; set; }
    
        public virtual ObjectResult<spcp_Get_Data_orden_pago_con_cancelacion_data_Result> spcp_Get_Data_orden_pago_con_cancelacion_data(Nullable<int> idEmpresa, Nullable<decimal> idPersona_ini, Nullable<decimal> idPersona_fin, string idTipoPersona, Nullable<decimal> idEntidad_ini, Nullable<decimal> idEntidad_fin, string idEstado_Aprobacion, string idUsuario, Nullable<bool> mostrar_saldo_0)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idPersona_iniParameter = idPersona_ini.HasValue ?
                new ObjectParameter("IdPersona_ini", idPersona_ini) :
                new ObjectParameter("IdPersona_ini", typeof(decimal));
    
            var idPersona_finParameter = idPersona_fin.HasValue ?
                new ObjectParameter("IdPersona_fin", idPersona_fin) :
                new ObjectParameter("IdPersona_fin", typeof(decimal));
    
            var idTipoPersonaParameter = idTipoPersona != null ?
                new ObjectParameter("IdTipoPersona", idTipoPersona) :
                new ObjectParameter("IdTipoPersona", typeof(string));
    
            var idEntidad_iniParameter = idEntidad_ini.HasValue ?
                new ObjectParameter("IdEntidad_ini", idEntidad_ini) :
                new ObjectParameter("IdEntidad_ini", typeof(decimal));
    
            var idEntidad_finParameter = idEntidad_fin.HasValue ?
                new ObjectParameter("IdEntidad_fin", idEntidad_fin) :
                new ObjectParameter("IdEntidad_fin", typeof(decimal));
    
            var idEstado_AprobacionParameter = idEstado_Aprobacion != null ?
                new ObjectParameter("IdEstado_Aprobacion", idEstado_Aprobacion) :
                new ObjectParameter("IdEstado_Aprobacion", typeof(string));
    
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(string));
    
            var mostrar_saldo_0Parameter = mostrar_saldo_0.HasValue ?
                new ObjectParameter("mostrar_saldo_0", mostrar_saldo_0) :
                new ObjectParameter("mostrar_saldo_0", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spcp_Get_Data_orden_pago_con_cancelacion_data_Result>("spcp_Get_Data_orden_pago_con_cancelacion_data", idEmpresaParameter, idPersona_iniParameter, idPersona_finParameter, idTipoPersonaParameter, idEntidad_iniParameter, idEntidad_finParameter, idEstado_AprobacionParameter, idUsuarioParameter, mostrar_saldo_0Parameter);
        }
    }
}
