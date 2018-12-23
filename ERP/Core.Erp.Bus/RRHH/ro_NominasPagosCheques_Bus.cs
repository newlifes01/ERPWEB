﻿using Core.Erp.Data.RRHH;
using Core.Erp.Info.CuentasPorPagar;
using Core.Erp.Bus.CuentasPorPagar;
using Core.Erp.Info.Helps;
using Core.Erp.Info.RRHH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Bus.RRHH
{
   public class ro_NominasPagosCheques_Bus
    {
        ro_NominasPagosCheques_Data odata = new ro_NominasPagosCheques_Data();
        public List<ro_NominasPagosCheques_Info> get_list(int IdEmpresa, DateTime Fechainicio, DateTime fechafin, bool estado)
        {
            try
            {
                return odata.get_list(IdEmpresa, Fechainicio, fechafin, estado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ro_NominasPagosCheques_Info get_info(int IdEmpresa, decimal IdArchivo)
        {
            try
            {
                return odata.get_info(IdEmpresa, IdArchivo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool guardarDB(ro_NominasPagosCheques_Info info)
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

        public bool modificarDB(ro_NominasPagosCheques_Info info)
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

        public bool anularDB(ro_NominasPagosCheques_Info info)
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

        // generar ordenes de pagos
        public List<cp_orden_pago_Info> get_op_x_empleados(ro_NominasPagosCheques_Info info)
        {
            try
            {
                List<cp_orden_pago_Info> lista_op = new List<cp_orden_pago_Info>();
                ro_periodo_Bus bus_periodo = new ro_periodo_Bus();
                var periodo = bus_periodo.get_info(info.IdEmpresa, info.IdPeriodo);
                cp_orden_pago_tipo_x_empresa_Bus bus_tipo_op = new cp_orden_pago_tipo_x_empresa_Bus();
                cp_orden_pago_tipo_x_empresa_Info info_tipo_op = new cp_orden_pago_tipo_x_empresa_Info();
                info_tipo_op = bus_tipo_op.get_info(info.IdEmpresa, cl_enumeradores.eTipoOrdenPago.ANTI_EMPLE.ToString());
                info.detalle.ForEach(item =>

                {

                    lista_op.Add(
                        new cp_orden_pago_Info
                        {

                            IdEmpresa = item.IdEmpresa,
                            Observacion = "Cancelacion sueldo y salarios de " + item.pe_nombreCompleto,
                            IdTipo_op = cl_enumeradores.eTipoOrdenPago.ANTI_PROVEE.ToString(),
                            IdTipo_Persona = cl_enumeradores.eTipoPersona.EMPLEA.ToString(),
                            IdPersona = item.IdPersona,
                            IdEntidad =Convert.ToDecimal( item.IdEmpleado),
                            Fecha = periodo.pe_FechaFin,
                            IdEstadoAprobacion = cl_enumeradores.eEstadoAprobacionOrdenPago.APRO.ToString(),
                            IdFormaPago = cl_enumeradores.eFormaPagoOrdenPago.CHEQUE.ToString(),
                            Estado = "A",
                            Fecha_Transac = DateTime.Now,
                            detalle = new List<cp_orden_pago_det_Info>
                            {
                                new cp_orden_pago_det_Info
                                {
                                    IdEmpresa=item.IdEmpresa,
                                    Secuencia=1,
                                    Valor_a_pagar=item.Valor,
                                    Referencia="Periodo "+info.IdPeriodo,
                                    Fecha_Pago=periodo.pe_FechaFin,
                                    IdEstadoAprobacion = cl_enumeradores.eEstadoAprobacionOrdenPago.APRO.ToString(),
                                    IdFormaPago = cl_enumeradores.eFormaPagoOrdenPago.CHEQUE.ToString(),
                                }
                            },
                            info_comprobante = new ct_cbtecble_Info
                            {
                                IdEmpresa = info.IdEmpresa,
                                cb_Fecha = periodo.pe_FechaFin,
                                cb_Anio = periodo.pe_FechaFin.Year,
                                cb_mes = periodo.pe_FechaFin.Month,
                                IdTipoCbte = 1,
                                cb_Estado = "A",
                                IdPeriodo = Convert.ToInt32(periodo.pe_FechaFin.Year.ToString() + periodo.pe_FechaFin.Month.ToString().PadLeft(2, '0')),
                                cb_Observacion = "Cancelación de sueldo del " + info.IdPeriodo + " ha " + item.pe_nombreCompleto,
                                lst_ct_cbtecble_det = new List<ct_cbtecble_det_Info>
                                {
                                    new ct_cbtecble_det_Info
                                    {
                                        IdEmpresa=item.IdEmpresa,
                                        IdTipoCbte=1,
                                        IdCtaCble=info_tipo_op.IdCtaCble,
                                        dc_Valor=item.Valor,
                                        dc_Observacion="Cancelación de sueldo del "+periodo.IdPeriodo+" ha "+item.pe_nombreCompleto,
                                        secuencia=1,
                                    },
                                    new ct_cbtecble_det_Info
                                    {
                                         IdEmpresa=item.IdEmpresa,
                                        IdTipoCbte=1,
                                        IdCtaCble=info_tipo_op.IdCtaCble,
                                        dc_Valor=item.Valor*-1,
                                        dc_Observacion="Cancelación de sueldo del "+info.IdPeriodo+" ha "+item.pe_nombreCompleto,
                                        secuencia=2,
                                    }

                                }

                            }

                        });

                });
                return lista_op;
            }
            catch (Exception)
            {


                throw;
            }
        }


    }
}
