﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Reportes.Inventario;
using System.Collections.Generic;
using Core.Erp.Bus.Reportes.Inventario;

namespace Core.Erp.Web.Reportes.Inventario
{
    public partial class INV_012_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public string usuario { get; set; }
        public string empresa { get; set; }
        public INV_012_Rpt()
        {
            InitializeComponent();
        }

        private void INV_012_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            lbl_empresa.Text = empresa;
            lbl_usuario.Text = usuario;
            int IdEmpresa = p_IdEmpresa.Value == null ? 0 : Convert.ToInt32(p_IdEmpresa.Value);
            int IdSucursal = p_IdSucursal.Value == null ? 0 : Convert.ToInt32(p_IdSucursal.Value);
            int IdBodega = p_IdBodega.Value == null ? 0 : Convert.ToInt32(p_IdBodega.Value);
            decimal IdProducto = string.IsNullOrEmpty(p_IdProducto.Value.ToString()) ? 0 : Convert.ToDecimal(p_IdProducto.Value);
            int IdMarca = string.IsNullOrEmpty(p_IdMarca.Value.ToString()) ? 0 : Convert.ToInt32(p_IdMarca.Value);
            DateTime fechaIni = p_fechaIni.Value == null ? DateTime.Now : Convert.ToDateTime(p_fechaIni.Value);
            int dIAS = p_dIAS.Value == null ? 0 : Convert.ToInt32(p_dIAS.Value);

            INV_012_Bus bus_rpt = new INV_012_Bus();
            List<INV_012_Info> lst_rpt = bus_rpt.get_list(IdEmpresa, IdSucursal, IdBodega, IdProducto, IdMarca, fechaIni, dIAS);
            this.DataSource = lst_rpt;
        }
    }
}
