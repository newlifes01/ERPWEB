﻿using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Erp.Bus.CuentasPorPagar;
using Core.Erp.Info.CuentasPorPagar;
using Core.Erp.Web.Helps;
using Core.Erp.Info.Helps;
using Core.Erp.Bus.General;
using Core.Erp.Info.General;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Bus.SeguridadAcceso;
using DevExpress.Web;
using Core.Erp.Bus.Inventario;

namespace Core.Erp.Web.Areas.CuentasPorPagar.Controllers
{
    public class SolicitudPagoController : Controller
    {
        #region Variables
        cp_SolicitudPago_Bus bus_solicitud = new cp_SolicitudPago_Bus();
        tb_sucursal_Bus bus_sucursal = new tb_sucursal_Bus();
        seg_usuario_Bus bus_usuario = new seg_usuario_Bus();
        cp_SolicitudPago_det_List List_det = new cp_SolicitudPago_det_List();
        cp_SolicitudPago_x_cruzar_List List_det_x_cruzar = new cp_SolicitudPago_x_cruzar_List();
        cp_SolicitudPagoDet_Bus bus_pago_Det = new cp_SolicitudPagoDet_Bus();
        #endregion
        #region Index

        public ActionResult Index()
        {
            cl_filtros_Info model = new cl_filtros_Info
            {
                IdEmpresa = Convert.ToInt32(SessionFixed.IdEmpresa),
                IdSucursal = Convert.ToInt32(SessionFixed.IdSucursal)
            };
            cargar_combos(model.IdEmpresa);
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(cl_filtros_Info model)
        {
            cargar_combos(model.IdEmpresa);
            return View(model);
        }
        private void cargar_combos(int IdEmpresa)
        {
            var lst_sucursal = bus_sucursal.get_list(IdEmpresa, false);
            ViewBag.lst_sucursal = lst_sucursal;
        }
        [ValidateInput(false)]
        public ActionResult GridViewPartial_solicitud_pago(DateTime? Fecha_ini, DateTime? Fecha_fin, int IdSucursal = 0)
        {

            int IdEmpresa = Convert.ToInt32(SessionFixed.IdEmpresa);

            ViewBag.IdSucursal = IdSucursal;
            ViewBag.Fecha_ini = Fecha_ini == null ? DateTime.Now.Date.AddMonths(-1) : Convert.ToDateTime(Fecha_ini);
            ViewBag.Fecha_fin = Fecha_fin == null ? DateTime.Now.Date : Convert.ToDateTime(Fecha_fin);
            var model = bus_solicitud.GetList(IdEmpresa, IdSucursal, ViewBag.Fecha_ini, ViewBag.Fecha_fin, true);
            return PartialView("_GridViewPartial_solicitud_pago", model);
        }
        #endregion
        #region Metodos ComboBox bajo demanda
        tb_persona_Bus bus_persona = new tb_persona_Bus();
        public ActionResult CmbProveedor_CXP()
        {
            decimal model = new decimal();
            return PartialView("_CmbProveedor_CXP", model);
        }
        public List<tb_persona_Info> get_list_bajo_demanda(ListEditItemsRequestedByFilterConditionEventArgs args)
        {
            return bus_persona.get_list_bajo_demanda(args, Convert.ToInt32(SessionFixed.IdEmpresa), cl_enumeradores.eTipoPersona.PROVEE.ToString());
        }
        public tb_persona_Info get_info_bajo_demanda(ListEditItemRequestedByValueEventArgs args)
        {
            return bus_persona.get_info_bajo_demanda(args, Convert.ToInt32(SessionFixed.IdEmpresa), cl_enumeradores.eTipoPersona.PROVEE.ToString());
        }
        #endregion
        #region Acciones
        public ActionResult Nuevo()
        {
            #region Validar Session
            if (string.IsNullOrEmpty(SessionFixed.IdTransaccionSession))
                return RedirectToAction("Login", new { Area = "", Controller = "Account" });
            SessionFixed.IdTransaccionSession = (Convert.ToDecimal(SessionFixed.IdTransaccionSession) + 1).ToString();
            SessionFixed.IdTransaccionSessionActual = SessionFixed.IdTransaccionSession;
            #endregion
            cp_SolicitudPago_Info model = new cp_SolicitudPago_Info
            {
                IdEmpresa = Convert.ToInt32(SessionFixed.IdEmpresa),
                Fecha = DateTime.Now,
                IdTransaccionSession = Convert.ToDecimal(SessionFixed.IdTransaccionSession),
                lst_det = new List<cp_SolicitudPagoDet_Info>()

            };
            List_det.set_list(model.lst_det, model.IdTransaccionSession);
            List_det_x_cruzar.set_list(model.lst_det, model.IdTransaccionSession);
            seg_usuario_Info mod = bus_usuario.get_info(SessionFixed.IdUsuario);
            model.Solicitante = mod.Nombre;
            cargar_combos(model.IdEmpresa);
            return View(model);
        }

        [HttpPost]
        public ActionResult Nuevo(cp_SolicitudPago_Info model)
        {
            model.IdUsuarioCreacion = SessionFixed.IdUsuario;
            model.lst_det = List_det.get_list(model.IdTransaccionSession);
            model.lst_det = List_det_x_cruzar.get_list(model.IdTransaccionSession);
            if (!bus_solicitud.GuardarDB(model))
            {
                cargar_combos(model.IdEmpresa);
                return View(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Modificar(int IdEmpresa = 0 , decimal IdSolicitud = 0)
        {
            #region Validar Session
            if (string.IsNullOrEmpty(SessionFixed.IdTransaccionSession))
                return RedirectToAction("Login", new { Area = "", Controller = "Account" });
            SessionFixed.IdTransaccionSession = (Convert.ToDecimal(SessionFixed.IdTransaccionSession) + 1).ToString();
            SessionFixed.IdTransaccionSessionActual = SessionFixed.IdTransaccionSession;
            #endregion
            cp_SolicitudPago_Info model = bus_solicitud.GetInfo(IdEmpresa, IdSolicitud);
            if (model == null)
                return RedirectToAction("Index");
            model.IdTransaccionSession = Convert.ToDecimal(SessionFixed.IdTransaccionSession);
            List_det.set_list(model.lst_det, model.IdTransaccionSession);
            List_det_x_cruzar.set_list(model.lst_det, model.IdTransaccionSession);
            cargar_combos(IdEmpresa);
            return View(model);
        }

        [HttpPost]
        public ActionResult Modificar(cp_SolicitudPago_Info model)
        {
            model.IdUsuarioModificacion = SessionFixed.IdUsuario;
            model.lst_det = List_det.get_list(model.IdTransaccionSession);
            model.lst_det = List_det_x_cruzar.get_list(model.IdTransaccionSession);
            if (!bus_solicitud.ModificarDB(model))
            {
                cargar_combos(model.IdEmpresa);
                return View(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Anular(int IdEmpresa = 0, decimal IdSolicitud = 0)
        {
            cp_SolicitudPago_Info model = bus_solicitud.GetInfo(IdEmpresa, IdSolicitud);
            if (model == null)
                return RedirectToAction("Index");
            model.IdTransaccionSession = Convert.ToDecimal(SessionFixed.IdTransaccionSession);
            List_det.set_list(model.lst_det, model.IdTransaccionSession);
            List_det_x_cruzar.set_list(model.lst_det, model.IdTransaccionSession);
            cargar_combos(IdEmpresa);
            return View(model);
        }

        [HttpPost]
        public ActionResult Anular(cp_SolicitudPago_Info model)
        {
            model.IdUsuarioAnulacion = SessionFixed.IdUsuario;
            if (!bus_solicitud.AnularDB(model))
            {
                cargar_combos(model.IdEmpresa);
                return View(model);
            }
            return RedirectToAction("Index");
        }

        #endregion
        #region Json

        public JsonResult GetListPorPagar(int IdEmpresa = 0 , int IdSucursal = 0, decimal IdTransaccionSession = 0)
        {
            bool resultado = true;
            var lst = bus_pago_Det.GetListPorPagar(IdEmpresa, IdSucursal);
            if (lst.Count() == 0)
                resultado = false;
            var det = List_det_x_cruzar.get_list(IdTransaccionSession);
            List_det_x_cruzar.set_list(det, IdTransaccionSession);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region Detalle
        [ValidateInput(false)]
        public ActionResult GridViewPartial_aprobacion()
        {
            SessionFixed.IdTransaccionSessionActual = Request.Params["TransaccionFixed"] != null ? Request.Params["TransaccionFixed"].ToString() : SessionFixed.IdTransaccionSessionActual;
            var model = List_det_x_cruzar.get_list(Convert.ToDecimal(SessionFixed.IdTransaccionSessionActual));
            return PartialView("_GridViewPartial_aprobacion", model);
        }
        public ActionResult GridViewPartial_aprobacion_solicitud(decimal IdFabricacion = 0)
        {
            SessionFixed.IdTransaccionSessionActual = Request.Params["TransaccionFixed"] != null ? Request.Params["TransaccionFixed"].ToString() : SessionFixed.IdTransaccionSessionActual;
            var model = List_det.get_list(Convert.ToDecimal(SessionFixed.IdTransaccionSessionActual));
            return PartialView("_GridViewPartial_aprobacion_solicitud", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EditingAddNewIngreso([ModelBinder(typeof(DevExpressEditorsBinder))] cp_SolicitudPagoDet_Info info_det)
        {
            if (ModelState.IsValid)
                List_det.AddRow(info_det, Convert.ToDecimal(SessionFixed.IdTransaccionSessionActual));
           var model = List_det.get_list(Convert.ToDecimal(SessionFixed.IdTransaccionSessionActual));
            return PartialView("_GridViewPartial_fabricacion_det_ing", model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult EditingUpdateIngreso([ModelBinder(typeof(DevExpressEditorsBinder))] cp_SolicitudPagoDet_Info info_det)
        {
            if (ModelState.IsValid)
                List_det.UpdateRow(info_det, Convert.ToDecimal(SessionFixed.IdTransaccionSessionActual));
            var model = List_det.get_list(Convert.ToDecimal(SessionFixed.IdTransaccionSessionActual));
            return PartialView("_GridViewPartial_fabricacion_det_ing", model);
        }
        public ActionResult EditingDeleteIngreso(int Secuencia)
        {
            List_det.DeleteRow(Secuencia, Convert.ToDecimal(SessionFixed.IdTransaccionSessionActual));
            var model = List_det.get_list(Convert.ToDecimal(SessionFixed.IdTransaccionSessionActual));
            return PartialView("_GridViewPartial_fabricacion_det_ing", model);
        }

        #endregion

    }
    public class cp_SolicitudPago_det_List
    {
        string variable = "cp_SolicitudPagoDet_Info";
        public List<cp_SolicitudPagoDet_Info> get_list(decimal IdTransaccionSession)
        {
            if (HttpContext.Current.Session[variable + IdTransaccionSession.ToString()] == null)
            {
                List<cp_SolicitudPagoDet_Info> list = new List<cp_SolicitudPagoDet_Info>();

                HttpContext.Current.Session[variable + IdTransaccionSession.ToString()] = list;
            }
            return (List<cp_SolicitudPagoDet_Info>)HttpContext.Current.Session[variable + IdTransaccionSession.ToString()];
        }

        public void set_list(List<cp_SolicitudPagoDet_Info> list, decimal IdTransaccionSession)
        {
            HttpContext.Current.Session[variable + IdTransaccionSession.ToString()] = list;
        }

        public void AddRow(cp_SolicitudPagoDet_Info info_det, decimal IdTransaccionSession)
        {
            List<cp_SolicitudPagoDet_Info> list = get_list(IdTransaccionSession);
            info_det.Secuencia = list.Count == 0 ? 1 : list.Max(q => q.Secuencia) + 1;
            if (list.Where(q => q.IdEmpresa_cxp == info_det.IdEmpresa_cxp && q.IdTipoCbte_cxp == info_det.IdTipoCbte_cxp && q.IdCbteCble_cxp == info_det.IdCbteCble_cxp).Count() == 0)
                list.Add(info_det);
        }

        public void UpdateRow(cp_SolicitudPagoDet_Info info_det, decimal IdTransaccionSession)
        {
            cp_SolicitudPagoDet_Info edited_info = get_list(IdTransaccionSession).Where(m => m.Secuencia == info_det.Secuencia).First();
            edited_info.ValorAPagar = info_det.ValorAPagar;
        }

        public void DeleteRow(int Secuencia, decimal IdTransaccionSession)
        {
            List<cp_SolicitudPagoDet_Info> list = get_list(IdTransaccionSession);
            list.Remove(list.Where(m => m.Secuencia == Secuencia).First());
        }
    }

    public class cp_SolicitudPago_x_cruzar_List
    {
        string Variable = "cp_SolicitudPagoDet_x_cruzar_Info";
        public List<cp_SolicitudPagoDet_Info> get_list(decimal IdTransaccionSession)
        {
            if (HttpContext.Current.Session[Variable + IdTransaccionSession.ToString()] == null)
            {
                List<cp_SolicitudPagoDet_Info> list = new List<cp_SolicitudPagoDet_Info>();

                HttpContext.Current.Session[Variable + IdTransaccionSession.ToString()] = list;
            }
            return (List<cp_SolicitudPagoDet_Info>)HttpContext.Current.Session[Variable + IdTransaccionSession.ToString()];
        }

        public void set_list(List<cp_SolicitudPagoDet_Info> list, decimal IdTransaccionSession)
        {
            HttpContext.Current.Session[Variable + IdTransaccionSession.ToString()] = list;
        }
    }

}