﻿using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;

namespace Core.Erp.Bus.Facturacion
{
    public class fa_factura_Bus
    {
        fa_factura_Data odata = new fa_factura_Data();
        public List<fa_factura_consulta_Info> get_list(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return odata.get_list(IdEmpresa, Fecha_ini,Fecha_fin);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public fa_factura_Info get_info(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return odata.get_info(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool factura_existe(int IdEmpresa, string Serie1, string Serie2, string NumFactura)
        {
            try
            {
                return odata.factura_existe(IdEmpresa, Serie1, Serie2, NumFactura);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool guardarDB(fa_factura_Info info)
        {
            try
            {
                return odata.guardarDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool modificarDB(fa_factura_Info info)
        {
            try
            {
                return odata.modificarDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool anularDB(fa_factura_Info info)
        {
            try
            {
                return odata.anularDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
