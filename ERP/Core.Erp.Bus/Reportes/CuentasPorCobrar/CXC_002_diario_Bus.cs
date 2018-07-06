﻿using Core.Erp.Data.Reportes.CuentasPorCobrar;
using Core.Erp.Info.Reportes.CuentasPorCobrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Bus.Reportes.CuentasPorCobrar
{
    class CXC_002_diario_Bus
    {
        CXC_002_diario_Data odata = new CXC_002_diario_Data();
        public List<CXC_002_diario_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega_Cbte, decimal IdCbte_cta_nota, string dc_TipoDocumento)
        {
            try
            {
                return odata.get_list(IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_cta_nota, dc_TipoDocumento);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
