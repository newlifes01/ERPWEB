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
    
    public partial class Entities_facturacion : DbContext
    {
        public Entities_facturacion()
            : base("name=Entities_facturacion")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<fa_cliente_tipo> fa_cliente_tipo { get; set; }
        public virtual DbSet<fa_TerminoPago> fa_TerminoPago { get; set; }
        public virtual DbSet<fa_TipoNota> fa_TipoNota { get; set; }
        public virtual DbSet<fa_PuntoVta> fa_PuntoVta { get; set; }
        public virtual DbSet<fa_formaPago> fa_formaPago { get; set; }
        public virtual DbSet<fa_Vendedor> fa_Vendedor { get; set; }
        public virtual DbSet<vwfa_cliente_consulta> vwfa_cliente_consulta { get; set; }
        public virtual DbSet<fa_cliente> fa_cliente { get; set; }
        public virtual DbSet<fa_cliente_contactos> fa_cliente_contactos { get; set; }
        public virtual DbSet<fa_cliente_x_fa_Vendedor_x_sucursal> fa_cliente_x_fa_Vendedor_x_sucursal { get; set; }
        public virtual DbSet<fa_TerminoPago_Distribucion> fa_TerminoPago_Distribucion { get; set; }
        public virtual DbSet<fa_proforma> fa_proforma { get; set; }
        public virtual DbSet<fa_proforma_det> fa_proforma_det { get; set; }
        public virtual DbSet<fa_factura> fa_factura { get; set; }
        public virtual DbSet<fa_factura_det> fa_factura_det { get; set; }
    }
}
