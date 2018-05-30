﻿using Core.Erp.Data.Reportes.Inventario;
using Core.Erp.Info.Reportes.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Bus.Reportes.Inventario
{
    public class INV_003_Bus
    {
        INV_003_Data odata = new INV_003_Data();
    
        public List<INV_003_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, string IdCategoria, int IdLinea, int IdGrupo, int IdSubgrupo, DateTime fecha_corte, bool mostrar_stock_0)
        {
            try
            {
                return odata.get_list(IdEmpresa, IdSucursal, IdBodega, IdProducto, IdCategoria, IdLinea, IdGrupo, IdSubgrupo, fecha_corte, mostrar_stock_0);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
