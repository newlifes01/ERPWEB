﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Erp.Info.CuentasPorPagar;
using Core.Erp.Bus.CuentasPorPagar;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Bus.Contabilidad;
using DevExpress.Web.Mvc;

namespace Core.Erp.Web.Areas.CuentasPorPagar.Controllers
{
    public class RetencionController : Controller
    {

       
            #region variables
            cp_retencion_Bus bus_retencion = new cp_retencion_Bus();
            cp_proveedor_Bus bus_proveedor = new cp_proveedor_Bus();
            ct_cbtecble_det_List_re comprobante_contable_rt = new ct_cbtecble_det_List_re();
             cp_retencion_det_lst detalle_retencion_info = new cp_retencion_det_lst();

        List<cp_retencion_det_Info> lst_detalle_ret = new List<cp_retencion_det_Info>();
            List<cp_retencion_Info> lst_retenciones = new List<cp_retencion_Info>();
            cp_parametros_Info info_param_op = new cp_parametros_Info();
            cp_parametros_Bus bus_parametros = new cp_parametros_Bus();
            List<cp_codigo_SRI_Info> lst_codigo_retencion = new List<cp_codigo_SRI_Info>();
            cp_codigo_SRI_Bus bus_codigo_ret = new cp_codigo_SRI_Bus();
            int IdEmpresa = 0;
            #endregion
            public ActionResult Index()
            {
                return View();
            }

            public ActionResult GridViewPartial_retenciones()
            {
                int IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
                lst_retenciones = bus_retencion.get_list(IdEmpresa, DateTime.Now, DateTime.Now);
                return PartialView("_GridViewPartial_retenciones", lst_retenciones);
            }
            [ValidateInput(false)]
            public ActionResult GridViewPartial_retencion_det()
            {
                try
                {
                cargar_combos_detalle();
                cp_retencion_Info info = new cp_retencion_Info();
                    lst_detalle_ret = Session["detalle_retencion"] as List<cp_retencion_det_Info>;
                info.detalle = lst_detalle_ret;
                if (info.detalle == null)
                    info = new cp_retencion_Info();
                return PartialView("_GridViewPartial_retencion_det", info);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            public ActionResult GridViewPartial_retencio_dc()
            {
                int IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
                ct_cbtecble_Info model = new ct_cbtecble_Info();
                model.lst_ct_cbtecble_det = Session["ct_cbtecble_det_Info"] as List<ct_cbtecble_det_Info>;
                cargar_combos_detalle();
                return PartialView("_GridViewPartial_retencio_dc", model);
            }

            private void cargar_combos(string TipoPersona = "")
            {
                int IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
                var lst_proveedores = bus_proveedor.get_list(IdEmpresa, false);
                ViewBag.lst_proveedores = lst_proveedores;

          


        }

            public ActionResult Nuevo(int IdTipoCbte_Ogiro = 0, decimal IdCbteCble_Ogiro = 0)
        {
                 cp_retencion_Info model = new cp_retencion_Info();
                  model.fecha = DateTime.Now;
                 IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
                 Session["ct_cbtecble_det_Info"] = null;
                 Session["detalle_retencion"] = null;

                 Session["info_param_op"] = bus_parametros.get_info(IdEmpresa);
                 model= bus_retencion.get_info_factura( IdEmpresa, IdTipoCbte_Ogiro, IdCbteCble_Ogiro);
            model.fecha = DateTime.Now;
            if (model.co_valoriva > 0)
                Session["co_valoriva"] = model.co_valoriva;
                 cargar_combos();
                 cargar_combos_detalle();
                 return View(model);
            }

            [HttpPost]
            public ActionResult Nuevo(cp_retencion_Info model)
            {
                bus_retencion = new cp_retencion_Bus();
                model.IdUsuario = Session["IdUsuario"].ToString();
                model.detalle = Session["detalle_retencion"] as List<cp_retencion_det_Info>;
                model.info_comprobante.lst_ct_cbtecble_det = Session["ct_cbtecble_det_Info"] as List<ct_cbtecble_det_Info>;
                info_param_op = Session["info_param_op"] as cp_parametros_Info;
                model.IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
                model.info_comprobante.IdTipoCbte = (int)info_param_op.pa_IdTipoCbte_x_Retencion;

                string mensaje = bus_retencion.validar(model);
                if (mensaje != "")
                {
                    cargar_combos();
                    ViewBag.mensaje = mensaje;
                    cargar_combos_detalle();
                    return View(model);
                }
                else
                {
                lst_codigo_retencion = Session["lst_codigo_retencion"] as List<cp_codigo_SRI_Info>;
                model.detalle.ForEach(item =>
                {
                    cp_codigo_SRI_Info info_ = lst_codigo_retencion.Where(v => v.codigoSRI == item.re_Codigo_impuesto).FirstOrDefault();
                    item.IdCodigo_SRI = info_.IdCodigo_SRI;
                    if (info_.IdTipoSRI == "COD_RET_IVA")
                    {
                        model.re_Tiene_RFuente = "S";
                        item.re_tipoRet = "IVA";
                    }
                    if (info_.IdTipoSRI == "COD_RET_FUE")
                    {
                        model.re_Tiene_RTiva = "S";
                        item.re_tipoRet = "RTF";
                    }
                });

                    if (bus_retencion.guardarDB(model))
                        return RedirectToAction("Index");
                    else
                    {
                        ViewBag.mensaje = mensaje;
                        cargar_combos();
                        cargar_combos_detalle();
                        return View(model);
                    }
                }
            }

            public ActionResult Modificar(int IdRetencion = 0)
            {
                cargar_combos();
                cargar_combos_detalle();
                IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
                Session["info_param_op"] = bus_parametros.get_info(IdEmpresa);

            cp_retencion_Info model = new cp_retencion_Info();
                model = bus_retencion.get_info(IdEmpresa, IdRetencion);
                Session["ct_cbtecble_Info"] = model.info_comprobante;
                Session["detalle_retencion"] = model.detalle;
                Session["ct_cbtecble_det_Info"] = model.info_comprobante.lst_ct_cbtecble_det;
                return View(model);
            }

            [HttpPost]
            public ActionResult Modificar(cp_retencion_Info model)
            {

            bus_retencion = new cp_retencion_Bus();
            model.IdUsuario = Session["IdUsuario"].ToString();
            model.detalle = Session["detalle_retencion"] as List<cp_retencion_det_Info>;
            model.info_comprobante.lst_ct_cbtecble_det = Session["ct_cbtecble_det_Info"] as List<ct_cbtecble_det_Info>;
            info_param_op = Session["info_param_op"] as cp_parametros_Info;
            model.IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
            model.info_comprobante.IdTipoCbte = (int)info_param_op.pa_IdTipoCbte_x_Retencion;

            string mensaje = bus_retencion.validar(model);
            if (mensaje != "")
            {
                cargar_combos();
                ViewBag.mensaje = mensaje;
                cargar_combos_detalle();
                return View(model);
            }
            else
            {
                lst_codigo_retencion = Session["lst_codigo_retencion"] as List<cp_codigo_SRI_Info>;
                model.detalle.ForEach(item =>
                {
                    cp_codigo_SRI_Info info_ = lst_codigo_retencion.Where(v => v.codigoSRI == item.re_Codigo_impuesto).FirstOrDefault();
                    item.IdCodigo_SRI = info_.IdCodigo_SRI;
                    if (info_.IdTipoSRI == "COD_RET_IVA")
                    {
                        model.re_Tiene_RFuente = "S";
                        item.re_tipoRet = "IVA";
                    }
                    if (info_.IdTipoSRI == "COD_RET_FUE")
                    {
                        model.re_Tiene_RTiva = "S";
                        item.re_tipoRet = "RTF";
                    }
                });

                if (bus_retencion.modificarDB(model))
                    return RedirectToAction("Index");
                else
                {
                    ViewBag.mensaje = mensaje;
                    cargar_combos();
                    cargar_combos_detalle();
                    return View(model);
                }
            }
        }
            public ActionResult Anular(int IdRetencion = 0)
            {
                cargar_combos();
                cargar_combos_detalle();
                IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
                Session["info_param_op"] = bus_parametros.get_info(IdEmpresa);

                cp_retencion_Info model = new cp_retencion_Info();
                model = bus_retencion.get_info(IdEmpresa, IdRetencion);
                Session["ct_cbtecble_Info"] = model.info_comprobante;
                Session["detalle_retencion"] = model.detalle;
                Session["ct_cbtecble_det_Info"] = model.info_comprobante.lst_ct_cbtecble_det;
                return View(model);
            }


            [HttpPost]
            public ActionResult Anular(cp_retencion_Info model)
            {

            bus_retencion = new cp_retencion_Bus();
            model.IdUsuario = Session["IdUsuario"].ToString();
            model.detalle = Session["detalle_retencion"] as List<cp_retencion_det_Info>;
            model.info_comprobante.lst_ct_cbtecble_det = Session["ct_cbtecble_det_Info"] as List<ct_cbtecble_det_Info>;
            info_param_op = Session["info_param_op"] as cp_parametros_Info;
            model.IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
            model.info_comprobante.IdTipoCbte = (int)info_param_op.pa_IdTipoCbte_x_Retencion;

            string mensaje = bus_retencion.validar(model);
            if (mensaje != "")
            {
                cargar_combos();
                ViewBag.mensaje = mensaje;
                cargar_combos_detalle();
                return View(model);
            }
            else
            {
                lst_codigo_retencion = Session["lst_codigo_retencion"] as List<cp_codigo_SRI_Info>;
                model.detalle.ForEach(item =>
                {
                    cp_codigo_SRI_Info info_ = lst_codigo_retencion.Where(v => v.codigoSRI == item.re_Codigo_impuesto).FirstOrDefault();
                    item.IdCodigo_SRI = info_.IdCodigo_SRI;
                    if (info_.IdTipoSRI == "COD_RET_IVA")
                    {
                        model.re_Tiene_RFuente = "S";
                        item.re_tipoRet = "IVA";
                    }
                    if (info_.IdTipoSRI == "COD_RET_FUE")
                    {
                        model.re_Tiene_RTiva = "S";
                        item.re_tipoRet = "RTF";
                    }
                });

                if (bus_retencion.anularDB(model))
                    return RedirectToAction("Index");
                else
                {
                    ViewBag.mensaje = mensaje;
                    cargar_combos();
                    cargar_combos_detalle();
                    return View(model);
                }
            }
        }
         

            [ValidateInput(false)]
            public ActionResult GridViewPartial_deudas()
            {
                int IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
                List<cp_retencion_Info> model = new List<cp_retencion_Info>();

                return PartialView("_GridViewPartial_deudas", model);
            }

            private void cargar_combos_detalle()
            {
                int IdEmpresa = Convert.ToInt32(Session["IdEmpresa"]);
                ct_plancta_Bus bus_cuenta = new ct_plancta_Bus();
                var lst_cuentas = bus_cuenta.get_list(IdEmpresa, false, true);
                ViewBag.lst_cuentas = lst_cuentas;
                lst_codigo_retencion = bus_codigo_ret.get_list_cod_ret(false);
                ViewBag.lst_codigo_retencion = lst_codigo_retencion;
                Session["lst_codigo_retencion"] = lst_codigo_retencion;
        }

            [HttpPost, ValidateInput(false)]
            public ActionResult EditingAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] ct_cbtecble_det_Info info_det)
            {
                if (ModelState.IsValid)
                    comprobante_contable_rt.AddRow(info_det);
                ct_cbtecble_Info model = new ct_cbtecble_Info();
                model.lst_ct_cbtecble_det = comprobante_contable_rt.get_list();
                cargar_combos_detalle();
                return PartialView("_GridViewPartial_retencio_dc", model);
            }

            [HttpPost, ValidateInput(false)]
            public ActionResult EditingUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] ct_cbtecble_det_Info info_det)
            {
                if (ModelState.IsValid)
                    comprobante_contable_rt.UpdateRow(info_det);
                ct_cbtecble_Info model = new ct_cbtecble_Info();
                model.lst_ct_cbtecble_det = comprobante_contable_rt.get_list();
                cargar_combos_detalle();
                return PartialView("_GridViewPartial_retencio_dc", model);
            }

            public ActionResult EditingDelete(int secuencia)
            {
                comprobante_contable_rt.DeleteRow(secuencia);
                ct_cbtecble_Info model = new ct_cbtecble_Info();
                model.lst_ct_cbtecble_det = comprobante_contable_rt.get_list();
                cargar_combos_detalle();
                return PartialView("_GridViewPartial_retencio_dc", model);
            }


        // grid de retencion
        [HttpPost, ValidateInput(false)]
        public ActionResult EditingAddNew_ret([ModelBinder(typeof(DevExpressEditorsBinder))]  cp_retencion_det_Info info_det)
        {
            cp_codigo_SRI_Info info_codifo_sri = new cp_codigo_SRI_Info();
            cp_retencion_Info model = new cp_retencion_Info();
            lst_codigo_retencion = Session["lst_codigo_retencion"] as List<cp_codigo_SRI_Info>;
            info_codifo_sri = lst_codigo_retencion.Where(v => v.codigoSRI == info_det.re_Codigo_impuesto).FirstOrDefault();
            info_det.re_Porcen_retencion = info_codifo_sri.co_porRetencion;
            if (info_codifo_sri.IdTipoSRI == "COD_RET_IVA")
            {
                if (Session["co_valoriva"] != null)
                {
                    info_det.re_baseRetencion = Convert.ToDouble(Session["co_valoriva"]);
                    info_det.re_valor_retencion = (info_det.re_baseRetencion * info_codifo_sri.co_porRetencion) / 100;


                    // calculando valores retencion
                    detalle_retencion_info.AddRow(info_det);
                    model.detalle = detalle_retencion_info.get_list();

                    // armando diario contable
                    var detalle = detalle_retencion_info.get_list();
                    info_param_op = Session["info_param_op"] as cp_parametros_Info;
                    comprobante_contable_rt.delete_detail_New_details(info_param_op, detalle);

                }
            }
            else
            {
                if (info_codifo_sri.co_porRetencion!=0 & info_det.re_baseRetencion!=null & info_det.re_baseRetencion!=0)
                {
                    info_det.re_valor_retencion = (info_det.re_baseRetencion * info_codifo_sri.co_porRetencion) / 100;



                    // calculando valores retencion
                    detalle_retencion_info.AddRow(info_det);
                    model.detalle = detalle_retencion_info.get_list();

                    // armando diario contable
                    var detalle = detalle_retencion_info.get_list();
                    info_param_op = Session["info_param_op"] as cp_parametros_Info;
                    comprobante_contable_rt.delete_detail_New_details(info_param_op, detalle);
                }


            }

           

            cargar_combos_detalle();
            model.detalle = detalle_retencion_info.get_list();
            return PartialView("_GridViewPartial_retencion_det", model);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult EditingUpdate_ret([ModelBinder(typeof(DevExpressEditorsBinder))] cp_retencion_det_Info info_det)
        {
            cp_codigo_SRI_Info info_codifo_sri = new cp_codigo_SRI_Info();
            cp_retencion_Info model = new cp_retencion_Info();
            lst_codigo_retencion = Session["lst_codigo_retencion"] as List<cp_codigo_SRI_Info>;
            info_codifo_sri = lst_codigo_retencion.Where(v => v.codigoSRI == info_det.re_Codigo_impuesto).FirstOrDefault();
            info_det.re_Porcen_retencion = info_codifo_sri.co_porRetencion;
            if (info_codifo_sri.IdTipoSRI == "COD_RET_IVA")
            {
                if (Session["co_valoriva"] != null)
                {
                    info_det.re_baseRetencion = Convert.ToDouble(Session["co_valoriva"]);
                    info_det.re_valor_retencion = (info_det.re_baseRetencion * info_codifo_sri.co_porRetencion) / 100;


                    // calculando valores retencion
                    detalle_retencion_info.UpdateRow(info_det);
                    model.detalle = detalle_retencion_info.get_list();

                    // armando diario contable
                    var detalle = detalle_retencion_info.get_list();
                    info_param_op = Session["info_param_op"] as cp_parametros_Info;
                    comprobante_contable_rt.delete_detail_New_details(info_param_op, detalle);

                }
            }
            else
            {
                if (info_codifo_sri.co_porRetencion != 0 & info_det.re_baseRetencion != null & info_det.re_baseRetencion != 0)
                {
                    info_det.re_valor_retencion = (info_det.re_baseRetencion * info_codifo_sri.co_porRetencion) / 100;



                    // calculando valores retencion
                    detalle_retencion_info.UpdateRow(info_det);
                    model.detalle = detalle_retencion_info.get_list();

                    // armando diario contable
                    var detalle = detalle_retencion_info.get_list();
                    info_param_op = Session["info_param_op"] as cp_parametros_Info;
                    comprobante_contable_rt.delete_detail_New_details(info_param_op, detalle);
                }


            }



            cargar_combos_detalle();
            model.detalle = detalle_retencion_info.get_list();
            return PartialView("_GridViewPartial_retencion_det", model);
        }

        public ActionResult EditingDelete_ret(int Idsecuencia)
        {
            detalle_retencion_info.DeleteRow(Idsecuencia);
            cp_retencion_Info model = new cp_retencion_Info();
            model.detalle = detalle_retencion_info.get_list();


            // armando diario contable
            var detalle = detalle_retencion_info.get_list();
            info_param_op = Session["info_param_op"] as cp_parametros_Info;
            comprobante_contable_rt.delete_detail_New_details(info_param_op, detalle);

            cargar_combos_detalle();
            return PartialView("_GridViewPartial_retencion_det", model);
        }


    }

    public class ct_cbtecble_det_List_re
        {
            public List<ct_cbtecble_det_Info> get_list()
            {
                if (HttpContext.Current.Session["ct_cbtecble_det_Info"] == null)
                {
                    List<ct_cbtecble_det_Info> list = new List<ct_cbtecble_det_Info>();

                    HttpContext.Current.Session["ct_cbtecble_det_Info"] = list;
                }
                return (List<ct_cbtecble_det_Info>)HttpContext.Current.Session["ct_cbtecble_det_Info"];
            }

            public void set_list(List<ct_cbtecble_det_Info> list)
            {
                HttpContext.Current.Session["ct_cbtecble_det_Info"] = list;
            }

            public void AddRow(ct_cbtecble_det_Info info_det)
            {
                List<ct_cbtecble_det_Info> list = get_list();
                info_det.secuencia = list.Count == 0 ? 1 : list.Max(q => q.secuencia) + 1;
                info_det.dc_Valor = info_det.dc_Valor_debe > 0 ? info_det.dc_Valor_debe : info_det.dc_Valor_haber * -1;
                list.Add(info_det);
            }

            public void UpdateRow(ct_cbtecble_det_Info info_det)
            {
                ct_cbtecble_det_Info edited_info = get_list().Where(m => m.secuencia == info_det.secuencia).First();
                edited_info.IdCtaCble = info_det.IdCtaCble;
                edited_info.dc_para_conciliar = info_det.dc_para_conciliar;
                edited_info.dc_Valor = info_det.dc_Valor_debe > 0 ? info_det.dc_Valor_debe : info_det.dc_Valor_haber * -1;
                edited_info.dc_Valor_debe = info_det.dc_Valor_debe;
                edited_info.dc_Valor_haber = info_det.dc_Valor_haber;
            }

            public void DeleteRow(int secuencia)
            {
                List<ct_cbtecble_det_Info> list = get_list();
                list.Remove(list.Where(m => m.secuencia == secuencia).First());
            }

            public void delete_detail_New_details(cp_parametros_Info info_param_op, List<cp_retencion_det_Info> detalle_retencion)
            {
            try
            {
                int sec = 1;

                HttpContext.Current.Session["ct_cbtecble_det_Info"] = null;

                foreach (var item in detalle_retencion)
                {
                    ct_cbtecble_det_Info cbtecble_debe_Info = new ct_cbtecble_det_Info();
                    cbtecble_debe_Info.secuencia = sec;
                    cbtecble_debe_Info.IdEmpresa = info_param_op.IdEmpresa;
                    cbtecble_debe_Info.IdTipoCbte = (int)info_param_op.pa_IdTipoCbte_x_Retencion;
                    cbtecble_debe_Info.IdCtaCble = info_param_op.pa_ctacble_x_RetFte_default;
                    cbtecble_debe_Info.dc_Valor_debe =(double) item.re_valor_retencion;
                    cbtecble_debe_Info.dc_Valor =(double) item.re_valor_retencion;
                    cbtecble_debe_Info.dc_Observacion = "";
                    sec++;
                    AddRow(cbtecble_debe_Info);
                }

                        ct_cbtecble_det_Info cbtecble_haber_Info = new ct_cbtecble_det_Info();
                        cbtecble_haber_Info.secuencia = 2;
                        cbtecble_haber_Info.IdEmpresa = info_param_op.IdEmpresa;
                        cbtecble_haber_Info.IdTipoCbte = (int)info_param_op.pa_IdTipoCbte_x_Retencion;
                        cbtecble_haber_Info.IdCtaCble = info_param_op.pa_ctacble_deudora;
                        cbtecble_haber_Info.dc_Valor_haber = detalle_retencion.Sum( v => Convert.ToDouble( v.re_valor_retencion));
                        cbtecble_haber_Info.dc_Valor = detalle_retencion.Sum(v => Convert.ToDouble(v.re_valor_retencion))*-1;
                        cbtecble_haber_Info.dc_Observacion = "";
                        AddRow(cbtecble_haber_Info);


                }
                catch (Exception)
                {

                    throw;
                }
            }


        }

    
    public class cp_retencion_det_lst
    {
        public List<cp_retencion_det_Info> get_list()
        {
            if (HttpContext.Current.Session["detalle_retencion"] == null)
            {
                List<cp_retencion_det_Info> list = new List<cp_retencion_det_Info>();

                HttpContext.Current.Session["detalle_retencion"] = list;
            }
            return (List<cp_retencion_det_Info>)HttpContext.Current.Session["detalle_retencion"];
        }

        public void set_list(List<cp_retencion_det_Info> list)
        {
            HttpContext.Current.Session["detalle_retencion"] = list;
        }

        public void AddRow(cp_retencion_det_Info info_det)
        {
            List<cp_retencion_det_Info> list = get_list();
            info_det.Idsecuencia = list.Count() + 1;        
            list.Add(info_det);
        }

        public void UpdateRow(cp_retencion_det_Info info_det)
        {
            cp_retencion_det_Info edited_info = get_list().Where(m => m.Idsecuencia == info_det.Idsecuencia).First();
            
        }

        public void DeleteRow(int secuencia)
        {
            List<cp_retencion_det_Info> list = get_list();
            list.Remove(list.Where(m => m.Idsecuencia == secuencia).First());
        }

   

    }

}