﻿using System;

namespace Core.Erp.Info.Facturacion
{
    public class fa_notaCreDeb_det_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNota { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double sc_cantidad { get; set; }
        public double sc_Precio { get; set; }
        public double sc_descUni { get; set; }
        public double sc_PordescUni { get; set; }
        public double sc_precioFinal { get; set; }
        public double sc_subtotal { get; set; }
        public double sc_iva { get; set; }
        public double sc_total { get; set; }
        public double sc_costo { get; set; }
        public string sc_observacion { get; set; }
        public string sc_estado { get; set; }
        public double vt_por_iva { get; set; }
        public Nullable<int> IdPunto_Cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public string IdCod_Impuesto_Ice { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        #region Campos que no existen en la tabla
        public string pr_descripcion { get; set; }
        public string lote_num_lote { get; set; }
        public DateTime? lote_fecha_vcto { get; set; }
        public string nom_presentacion { get; set; }
        #endregion

    }
}