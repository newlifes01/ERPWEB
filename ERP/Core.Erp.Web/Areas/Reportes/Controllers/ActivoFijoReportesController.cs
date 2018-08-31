﻿using Core.Erp.Web.Reportes.ActivoFijo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Erp.Info.Reportes.ActivoFijo;
using Core.Erp.Info.Helps;
using Core.Erp.Bus.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Web.Helps;

namespace Core.Erp.Web.Areas.Reportes.Controllers
{
    public class ActivoFijoReportesController : Controller
    {

        public ActionResult ACTF_001(decimal Id_Mejora_Baja_Activo = 0, string Id_Tipo = "" )
        {
            ACTF_001_Rpt model = new ACTF_001_Rpt();
            model.p_IdEmpresa.Value = Convert.ToInt32(Session["IdEmpresa"]);
            model.p_Id_Mejora_Baja_Activo.Value = Id_Mejora_Baja_Activo;
            model.p_Id_Tipo.Value = Id_Tipo;
            model.usuario = Session["IdUsuario"].ToString();
            model.empresa = Session["nom_empresa"].ToString();
            if (Id_Mejora_Baja_Activo != 0)
            {
                model.p_IdEmpresa.Visible = false;
                model.p_Id_Mejora_Baja_Activo.Visible = false;
                model.p_Id_Tipo.Visible = false;
            }
            else
                model.RequestParameters = false;
            return View(model);
        }

        public ActionResult ACTF_002(decimal IdVtaActivo = 0)
        {
            ACTF_002_Rpt model = new ACTF_002_Rpt();
            model.p_IdEmpresa.Value = Convert.ToInt32(Session["IdEmpresa"]);
            model.p_IdVtaActivo.Value = IdVtaActivo;
            model.usuario = Session["IdUsuario"].ToString();
            model.empresa = Session["nom_empresa"].ToString();
            if (IdVtaActivo != 0)
            {
                model.p_IdEmpresa.Visible = false;
                model.p_IdVtaActivo.Visible = false;
            }
            else
                model.RequestParameters = false;
            return View(model);
        }

        public ActionResult ACTF_003(decimal IdRetiroActivo = 0)
        {
            ACTF_003_Rpt model = new ACTF_003_Rpt();
            model.p_IdEmpresa.Value = Convert.ToInt32(Session["IdEmpresa"]);
            model.p_IdRetiroActivo.Value = IdRetiroActivo;
            model.usuario = Session["IdUsuario"].ToString();
            model.empresa = Session["nom_empresa"].ToString();
            if (IdRetiroActivo != 0)
            {
                model.p_IdEmpresa.Visible = false;
                model.p_IdRetiroActivo.Visible = false;
            }
            else
                model.RequestParameters = false;
            return View(model);

        }

        public ActionResult ACTF_004( bool  mostrar_detallado = false)
        {
            cl_filtros_Info model = new cl_filtros_Info
            {
                IdEmpresa = Convert.ToInt32(SessionFixed.IdEmpresa)
            };

            if (mostrar_detallado)
            {
                ACTF_004_detalle_Rpt model_detalle = new ACTF_004_detalle_Rpt();
                model_detalle.p_IdEmpresa.Value = model.IdEmpresa;
                model_detalle.p_IdActivoFijoTipo.Value = model.IdActivoFijoTipo;
                model_detalle.p_IdCategoriaAF.Value = model.IdCategoriaAF;
                model_detalle.p_fecha_corte.Value = model.fecha_fin;
                model_detalle.p_Estado_Proceso.Value = model.Estado_Proceso;
                model_detalle.p_IdUsuario.Value = model.IdUsuario;
                cargar_combos(model);

                model_detalle.usuario = SessionFixed.IdUsuario.ToString();
                model_detalle.empresa = SessionFixed.NomEmpresa.ToString();
                ViewBag.report = model_detalle;
            }
            else
            {
                ACTF_004_resumen_Rpt model_resumen = new ACTF_004_resumen_Rpt();
                model_resumen.p_IdEmpresa.Value = model.IdEmpresa;
                model_resumen.p_IdActivoFijoTipo.Value = model.IdActivoFijoTipo;
                model_resumen.p_IdCategoriaAF.Value = model.IdCategoriaAF;
                model_resumen.p_fecha_corte.Value = model.fecha_fin;
                model_resumen.p_Estado_Proceso.Value = model.Estado_Proceso;
                model_resumen.p_IdUsuario.Value = model.IdUsuario;
                cargar_combos(model);

                model_resumen.usuario = SessionFixed.IdUsuario.ToString();
                model_resumen.empresa = SessionFixed.NomEmpresa.ToString();
                ViewBag.report = model_resumen;
            }
            cargar_combos(model);
            return View();
        }
        [HttpPost]
        public ActionResult ACTF_004(cl_filtros_Info model, bool mostrar_detallado = false)
        {

            if (mostrar_detallado)
            {
                ACTF_004_detalle_Rpt report = new ACTF_004_detalle_Rpt();
                report.p_IdEmpresa.Value = model.IdEmpresa;
                report.p_IdActivoFijoTipo.Value = model.IdActivoFijoTipo;
                report.p_IdCategoriaAF.Value = model.IdCategoriaAF;
                report.p_Estado_Proceso.Value = model.Estado_Proceso;
                report.p_IdUsuario.Value = model.IdUsuario;
                report.p_fecha_corte.Value = model.fecha_fin;
                report.usuario = Session["IdUsuario"].ToString();
                report.empresa = Session["nom_empresa"].ToString();
                cargar_combos(model);
                report.RequestParameters = false;
                ViewBag.Report = report;
            }
            else
            {
                ACTF_004_resumen_Rpt report = new ACTF_004_resumen_Rpt();
                report.p_IdEmpresa.Value = model.IdEmpresa;
                report.p_IdActivoFijoTipo.Value = model.IdActivoFijoTipo;
                report.p_IdCategoriaAF.Value = model.IdCategoriaAF;
                report.p_Estado_Proceso.Value = model.Estado_Proceso;
                report.p_IdUsuario.Value = model.IdUsuario;
                report.p_fecha_corte.Value = model.fecha_fin;
                report.usuario = Session["IdUsuario"].ToString();
                report.empresa = Session["nom_empresa"].ToString();
                cargar_combos(model);
                report.RequestParameters = false;
                ViewBag.Report = report;
            }
            return View(model);
        }

        private void cargar_combos(cl_filtros_Info model)
        {

            Af_Activo_fijo_Categoria_Bus bus_categoria = new Af_Activo_fijo_Categoria_Bus();
            var lst_categoria = bus_categoria.get_list(model.IdEmpresa, model.IdActivoFijoTipo, false);
            lst_categoria.Add(new Af_Activo_fijo_Categoria_Info
            {
                IdEmpresa = model.IdEmpresa,
                IdCategoriaAF = 0,
                Descripcion = "Todos"
            });
            ViewBag.lst_categoria = lst_categoria;

            Af_Catalogo_Bus bus_catalogo = new Af_Catalogo_Bus();
            var lst_estado = bus_catalogo.get_list(Convert.ToString(cl_enumeradores.eTipoCatalogoAF.TIP_ESTADO_AF), false);
            lst_estado.Add(new Af_Catalogo_Info
            {
                IdCatalogo = "",
                Descripcion = "Todos"
            });
            ViewBag.lst_estado = lst_estado;
            
            Af_Activo_fijo_tipo_Bus bus_activo = new Af_Activo_fijo_tipo_Bus();
            var lst_activo = bus_activo.get_list(model.IdEmpresa, false);
            lst_activo.Add(new Af_Activo_fijo_tipo_Info
            {
                IdEmpresa = model.IdEmpresa,
                IdActivoFijoTipo = 0,
                Af_Descripcion = "Todos"
            });
            ViewBag.lst_activo = lst_activo;


        }
        #region Json
        public JsonResult cargar_categoria(int IdEmpresa = 0 , int IdActivoFijoTipo = 0)
        {
            Af_Activo_fijo_Categoria_Bus bus_categoria = new Af_Activo_fijo_Categoria_Bus();
            var resultado = bus_categoria.get_list(IdEmpresa, IdActivoFijoTipo, false);
            resultado.Add(new Af_Activo_fijo_Categoria_Info
            {
                IdEmpresa = IdEmpresa,
                IdCategoriaAF = 0,
                Descripcion = "Todos"
            });
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
        #endregion
        public ActionResult ACTF_005()
        {
            cl_filtros_Info model = new cl_filtros_Info
            {
                IdEmpresa = Convert.ToInt32(SessionFixed.IdEmpresa)

            };
            ACTF_005_Rpt report = new ACTF_005_Rpt();
            report.p_IdEmpresa.Value = model.IdEmpresa;
            report.p_IdActivoFijoTipo.Value = model.IdActivoFijoTipo;
            report.p_IdCategoriaAF.Value = model.IdCategoriaAF;
            report.p_fecha_corte.Value = model.fecha_corte;
            report.p_Estado_Proceso.Value = model.Estado_Proceso;
            report.usuario = SessionFixed.IdUsuario.ToString();
            report.empresa = SessionFixed.NomEmpresa.ToString();
            ViewBag.Report = report;
            cargar_combos(model);
            return View(model);
        }
        [HttpPost]
        public ActionResult ACTF_005(cl_filtros_Info model)
        {
            ACTF_005_Rpt report = new ACTF_005_Rpt();
            report.p_IdEmpresa.Value = model.IdEmpresa;
            report.p_IdActivoFijoTipo.Value = model.IdActivoFijoTipo;
            report.p_IdCategoriaAF.Value = model.IdCategoriaAF;
            report.p_Estado_Proceso.Value = model.Estado_Proceso;
            report.p_fecha_corte.Value = model.fecha_corte;
            cargar_combos(model);
            report.usuario = SessionFixed.IdUsuario.ToString();
            report.empresa = SessionFixed.NomEmpresa.ToString();
            ViewBag.Report = report;
            return View(model);
        }
    }
}