﻿using Core.Erp.Info.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_cbtecble_det_Data
    {
        public List<ct_cbtecble_det_Info> get_list(int IdEmpresa,int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                List<ct_cbtecble_det_Info> Lista;
                using (Entities_contabilidad Context = new Entities_contabilidad())
                {
                    Lista = (from q in Context.vwct_cbtecble_det
                             where q.IdEmpresa == IdEmpresa
                             && q.IdTipoCbte == IdTipoCbte
                             && q.IdCbteCble == IdCbteCble
                             select new ct_cbtecble_det_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 dc_Observacion = q.dc_Observacion,
                                 dc_Valor = q.dc_Valor,
                                 IdCbteCble = q.IdCbteCble,
                                 IdCtaCble = q.IdCtaCble,                                 
                                 IdTipoCbte = q.IdTipoCbte,
                                 secuencia = q.secuencia,
                                 dc_para_conciliar_null = q.dc_para_conciliar,
                                 IdGrupoPresupuesto = q.IdGrupoPresupuesto,
                                 pc_Cuenta = q.pc_Cuenta
                             }).ToList();
                }
                Lista.ForEach(q => { q.dc_Valor_debe = q.dc_Valor > 0 ? q.dc_Valor : 0; q.dc_Valor_haber = q.dc_Valor < 0 ? Math.Abs( q.dc_Valor) : 0; q.dc_para_conciliar = q.dc_para_conciliar_null == null ? false : Convert.ToBoolean(q.dc_para_conciliar_null); });
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

