﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
namespace Core.Erp.Bus.Inventario
{
   public class in_producto_x_tb_bodega_Costo_Historico_Bus
    {
        in_producto_x_tb_bodega_Costo_Historico_Data odata = new in_producto_x_tb_bodega_Costo_Historico_Data();
        public double get_ultimo_costo(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, DateTime Fecha)
        {
            try
            {
                return odata.get_ultimo_costo(IdEmpresa,IdSucursal,IdBodega,IdProducto,Fecha);
            }
            catch (Exception)
            {

                throw;
            }
        }
        }
}
