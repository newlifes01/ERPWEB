﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;


    public partial class Entities_rrhh : DbContext
    {
        public Entities_rrhh()
            : base("name=Entities_rrhh")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ro_Acta_Finiquito> ro_Acta_Finiquito { get; set; }
        public DbSet<ro_Acta_Finiquito_Detalle> ro_Acta_Finiquito_Detalle { get; set; }
        public DbSet<ro_area> ro_area { get; set; }
        public DbSet<ro_area_x_departamento> ro_area_x_departamento { get; set; }
        public DbSet<ro_Capacitaciones_x_Empleado> ro_Capacitaciones_x_Empleado { get; set; }
        public DbSet<ro_cargaFamiliar> ro_cargaFamiliar { get; set; }
        public DbSet<ro_catalogo> ro_catalogo { get; set; }
        public DbSet<ro_catalogoTipo> ro_catalogoTipo { get; set; }
        public DbSet<ro_Comprobantes_Contables> ro_Comprobantes_Contables { get; set; }
        public DbSet<ro_Config_Param_contable> ro_Config_Param_contable { get; set; }
        public DbSet<ro_Departamento> ro_Departamento { get; set; }
        public DbSet<ro_Division> ro_Division { get; set; }
        public DbSet<ro_DocumentoxEmp> ro_DocumentoxEmp { get; set; }
        public DbSet<ro_empleado_x_horario> ro_empleado_x_horario { get; set; }
        public DbSet<ro_empleado_x_ro_tipoNomina> ro_empleado_x_ro_tipoNomina { get; set; }
        public DbSet<ro_empleado_x_rubro_acumulado> ro_empleado_x_rubro_acumulado { get; set; }
        public DbSet<ro_empleado_x_titulos> ro_empleado_x_titulos { get; set; }
        public DbSet<ro_Historico_Liquidacion_Vacaciones> ro_Historico_Liquidacion_Vacaciones { get; set; }
        public DbSet<ro_Historico_Liquidacion_Vacaciones_Det> ro_Historico_Liquidacion_Vacaciones_Det { get; set; }
        public DbSet<ro_historico_vacaciones_x_empleado> ro_historico_vacaciones_x_empleado { get; set; }
        public DbSet<ro_horario> ro_horario { get; set; }
        public DbSet<ro_horario_planificacion> ro_horario_planificacion { get; set; }
        public DbSet<ro_horario_planificacion_det> ro_horario_planificacion_det { get; set; }
        public DbSet<ro_Nomina_Tipo> ro_Nomina_Tipo { get; set; }
        public DbSet<ro_Nomina_Tipoliqui> ro_Nomina_Tipoliqui { get; set; }
        public DbSet<ro_nomina_x_horas_extras> ro_nomina_x_horas_extras { get; set; }
        public DbSet<ro_nomina_x_horas_extras_det> ro_nomina_x_horas_extras_det { get; set; }
        public DbSet<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar> ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar { get; set; }
        public DbSet<ro_participacion_utilidad> ro_participacion_utilidad { get; set; }
        public DbSet<ro_participacion_utilidad_empleado> ro_participacion_utilidad_empleado { get; set; }
        public DbSet<ro_periodo> ro_periodo { get; set; }
        public DbSet<ro_periodo_x_ro_Nomina_TipoLiqui> ro_periodo_x_ro_Nomina_TipoLiqui { get; set; }
        public DbSet<ro_Solicitud_Vacaciones_x_empleado> ro_Solicitud_Vacaciones_x_empleado { get; set; }
        public DbSet<ro_Tipo_Prestamo> ro_Tipo_Prestamo { get; set; }
        public DbSet<ro_turno> ro_turno { get; set; }
        public DbSet<vwRo_ActaFiniquito> vwRo_ActaFiniquito { get; set; }
        public DbSet<vwro_empleado_x_rubro_acumulado> vwro_empleado_x_rubro_acumulado { get; set; }
        public DbSet<vwro_empleado_x_titulos> vwro_empleado_x_titulos { get; set; }
        public DbSet<vwro_Historico_Liquidacion_Vacaciones> vwro_Historico_Liquidacion_Vacaciones { get; set; }
        public DbSet<vwro_horario_planificacion_det> vwro_horario_planificacion_det { get; set; }
        public DbSet<vwro_participacion_utilidad> vwro_participacion_utilidad { get; set; }
        public DbSet<vwro_participacion_utilidad_empleado> vwro_participacion_utilidad_empleado { get; set; }
        public DbSet<vwro_rubro_tipo> vwro_rubro_tipo { get; set; }
        public DbSet<ro_tabla_Impu_Renta> ro_tabla_Impu_Renta { get; set; }
        public DbSet<vwro_empleado_x_Proyeccion_Gastos_Personales> vwro_empleado_x_Proyeccion_Gastos_Personales { get; set; }
        public DbSet<vwrdep_IngrEgr_x_Empleado> vwrdep_IngrEgr_x_Empleado { get; set; }
        public DbSet<ro_marcaciones_tipo> ro_marcaciones_tipo { get; set; }
        public DbSet<ro_permiso_x_empleado> ro_permiso_x_empleado { get; set; }
        public DbSet<ro_empleado_x_ro_rubro> ro_empleado_x_ro_rubro { get; set; }
        public DbSet<vwro_empleado_x_ro_rubro> vwro_empleado_x_ro_rubro { get; set; }
        public DbSet<ro_empleado_proyeccion_gastos> ro_empleado_proyeccion_gastos { get; set; }
        public DbSet<ro_empleado_proyeccion_gastos_det> ro_empleado_proyeccion_gastos_det { get; set; }
        public DbSet<ro_tipo_gastos_personales> ro_tipo_gastos_personales { get; set; }
        public DbSet<ro_empleado_novedad_det> ro_empleado_novedad_det { get; set; }
        public DbSet<vwro_Empleado_Novedades> vwro_Empleado_Novedades { get; set; }
        public DbSet<ro_tipo_gastos_personales_tabla_valores_x_anio> ro_tipo_gastos_personales_tabla_valores_x_anio { get; set; }
        public DbSet<ro_rol_detalle> ro_rol_detalle { get; set; }
        public DbSet<vwro_rol_detalle_generar_op> vwro_rol_detalle_generar_op { get; set; }
        public DbSet<ro_rol_detalle_x_rubro_acumulado> ro_rol_detalle_x_rubro_acumulado { get; set; }
        public DbSet<ro_EmpleadoNovedadCargaMasiva> ro_EmpleadoNovedadCargaMasiva { get; set; }
        public DbSet<ro_EmpleadoNovedadCargaMasiva_det> ro_EmpleadoNovedadCargaMasiva_det { get; set; }
        public DbSet<vwro_EmpleadoNovedadCargaMasiva_det> vwro_EmpleadoNovedadCargaMasiva_det { get; set; }
        public DbSet<vwro_EmpleadoNovedadCargaMasiva> vwro_EmpleadoNovedadCargaMasiva { get; set; }
        public DbSet<vwro_marcaciones_x_empleado> vwro_marcaciones_x_empleado { get; set; }
        public DbSet<ro_contrato> ro_contrato { get; set; }
        public DbSet<ro_archivos_bancos_generacion_x_empleado> ro_archivos_bancos_generacion_x_empleado { get; set; }
        public DbSet<vwro_archivos_bancos_generacion_x_empleado> vwro_archivos_bancos_generacion_x_empleado { get; set; }
        public DbSet<ro_EmpleadoFoto> ro_EmpleadoFoto { get; set; }
        public DbSet<vwro_ArchivosIess> vwro_ArchivosIess { get; set; }
        public DbSet<ro_HorasProfesores> ro_HorasProfesores { get; set; }
        public DbSet<ro_HorasProfesores_det> ro_HorasProfesores_det { get; set; }
        public DbSet<vwro_HorasProfesores> vwro_HorasProfesores { get; set; }
        public DbSet<vwro_HorasProfesores_det> vwro_HorasProfesores_det { get; set; }
        public DbSet<vwro_nomina_sin_percebir_sueldo> vwro_nomina_sin_percebir_sueldo { get; set; }
        public DbSet<ro_FormulaHorasRecargo> ro_FormulaHorasRecargo { get; set; }
        public DbSet<vwRo_Solicitud_Vacaciones> vwRo_Solicitud_Vacaciones { get; set; }
        public DbSet<vwro_empleado_novedad_det> vwro_empleado_novedad_det { get; set; }
        public DbSet<ro_NominasPagosCheques> ro_NominasPagosCheques { get; set; }
        public DbSet<vwRo_rol_detalle_saldo_por_pagar> vwRo_rol_detalle_saldo_por_pagar { get; set; }
        public DbSet<vwro_NominasPagosCheques> vwro_NominasPagosCheques { get; set; }
        public DbSet<ro_NominasPagosCheques_det> ro_NominasPagosCheques_det { get; set; }
        public DbSet<vwro_NominasPagosCheques_det> vwro_NominasPagosCheques_det { get; set; }
        public DbSet<ro_prestamo> ro_prestamo { get; set; }
        public DbSet<ro_prestamo_detalle> ro_prestamo_detalle { get; set; }
        public DbSet<vwro_marcaciones_x_planificacion_horario> vwro_marcaciones_x_planificacion_horario { get; set; }
        public DbSet<vwro_SancionesPorMarcaciones_x_novedad> vwro_SancionesPorMarcaciones_x_novedad { get; set; }
        public DbSet<vwro_SancionesPorMarcaciones> vwro_SancionesPorMarcaciones { get; set; }
        public DbSet<ro_marcaciones_x_empleado> ro_marcaciones_x_empleado { get; set; }
        public DbSet<ro_SancionesPorMarcaciones_x_novedad> ro_SancionesPorMarcaciones_x_novedad { get; set; }
        public DbSet<ro_SancionesPorMarcaciones_det> ro_SancionesPorMarcaciones_det { get; set; }
        public DbSet<vwro_SancionesPorMarcaciones_det> vwro_SancionesPorMarcaciones_det { get; set; }
        public DbSet<ro_SancionesPorMarcaciones> ro_SancionesPorMarcaciones { get; set; }
        public DbSet<ro_empleado> ro_empleado { get; set; }
        public DbSet<vwro_empleado_combo> vwro_empleado_combo { get; set; }
        public DbSet<vwro_empleado_datos_generales> vwro_empleado_datos_generales { get; set; }
        public DbSet<ro_rol> ro_rol { get; set; }
        public DbSet<vwro_rol> vwro_rol { get; set; }
        public DbSet<ro_cargo> ro_cargo { get; set; }
        public DbSet<vwro_nomina_x_horas_extras_aprobadas> vwro_nomina_x_horas_extras_aprobadas { get; set; }
        public DbSet<vwro_nomina_x_horas_extras_det> vwro_nomina_x_horas_extras_det { get; set; }
        public DbSet<vwro_empleados_consulta> vwro_empleados_consulta { get; set; }
        public DbSet<ro_Parametros> ro_Parametros { get; set; }
        public DbSet<vwro_archivos_bancos_generacion> vwro_archivos_bancos_generacion { get; set; }
        public DbSet<ro_archivos_bancos_generacion> ro_archivos_bancos_generacion { get; set; }
        public DbSet<vwRo_Prestamo> vwRo_Prestamo { get; set; }
        public DbSet<ro_rubros_calculados> ro_rubros_calculados { get; set; }
        public DbSet<ro_empleado_x_jornada> ro_empleado_x_jornada { get; set; }
        public DbSet<ro_jornada> ro_jornada { get; set; }
        public DbSet<ro_novedad_x_empleado> ro_novedad_x_empleado { get; set; }
        public DbSet<vwro_empleado_x_jornada> vwro_empleado_x_jornada { get; set; }
        public DbSet<ro_empleado_Novedad> ro_empleado_Novedad { get; set; }
        public DbSet<vwro_empleado_Novedad> vwro_empleado_Novedad { get; set; }
        public DbSet<ro_empleado_x_CuentaContable> ro_empleado_x_CuentaContable { get; set; }
        public DbSet<ro_empleado_x_division_x_area> ro_empleado_x_division_x_area { get; set; }
        public DbSet<vwro_empleado_x_division_x_area> vwro_empleado_x_division_x_area { get; set; }
        public DbSet<ro_rubro_tipo> ro_rubro_tipo { get; set; }
        public DbSet<vwro_rol_detalle> vwro_rol_detalle { get; set; }
    
        public virtual int spRo_LiquidarEmpleado(Nullable<int> idEmpresa, Nullable<decimal> idActaFiniquito)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idActaFiniquitoParameter = idActaFiniquito.HasValue ?
                new ObjectParameter("IdActaFiniquito", idActaFiniquito) :
                new ObjectParameter("IdActaFiniquito", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRo_LiquidarEmpleado", idEmpresaParameter, idActaFiniquitoParameter);
        }
    
        public virtual int spRo_nomina_calculo_he(Nullable<int> idEmpresa, Nullable<decimal> idNomina, Nullable<decimal> idNominaTipo, Nullable<decimal> idPEriodo, string idUsuario, string observacion)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idNominaParameter = idNomina.HasValue ?
                new ObjectParameter("IdNomina", idNomina) :
                new ObjectParameter("IdNomina", typeof(decimal));
    
            var idNominaTipoParameter = idNominaTipo.HasValue ?
                new ObjectParameter("IdNominaTipo", idNominaTipo) :
                new ObjectParameter("IdNominaTipo", typeof(decimal));
    
            var idPEriodoParameter = idPEriodo.HasValue ?
                new ObjectParameter("IdPEriodo", idPEriodo) :
                new ObjectParameter("IdPEriodo", typeof(decimal));
    
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(string));
    
            var observacionParameter = observacion != null ?
                new ObjectParameter("observacion", observacion) :
                new ObjectParameter("observacion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRo_nomina_calculo_he", idEmpresaParameter, idNominaParameter, idNominaTipoParameter, idPEriodoParameter, idUsuarioParameter, observacionParameter);
        }
    
        public virtual ObjectResult<spro_nomina_x_pago_utilidad_Result> spro_nomina_x_pago_utilidad(Nullable<int> idempresa, Nullable<int> idNomina, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin)
        {
            var idempresaParameter = idempresa.HasValue ?
                new ObjectParameter("Idempresa", idempresa) :
                new ObjectParameter("Idempresa", typeof(int));
    
            var idNominaParameter = idNomina.HasValue ?
                new ObjectParameter("IdNomina", idNomina) :
                new ObjectParameter("IdNomina", typeof(int));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spro_nomina_x_pago_utilidad_Result>("spro_nomina_x_pago_utilidad", idempresaParameter, idNominaParameter, fechaInicioParameter, fechaFinParameter);
        }
    
        public virtual int sprol_CancelarNovedades_Prestamos(Nullable<int> idEmpresa, Nullable<int> idNomina, Nullable<int> idNominaTipo, Nullable<int> idPeriodo)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idNominaParameter = idNomina.HasValue ?
                new ObjectParameter("IdNomina", idNomina) :
                new ObjectParameter("IdNomina", typeof(int));
    
            var idNominaTipoParameter = idNominaTipo.HasValue ?
                new ObjectParameter("IdNominaTipo", idNominaTipo) :
                new ObjectParameter("IdNominaTipo", typeof(int));
    
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sprol_CancelarNovedades_Prestamos", idEmpresaParameter, idNominaParameter, idNominaTipoParameter, idPeriodoParameter);
        }
    
        public virtual int spRo_Cierre_Rol(Nullable<int> idEmpresa, Nullable<int> idPeriodo, Nullable<int> idNomina_Tipo, Nullable<int> idNomina_TipoLiqui)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            var idNomina_TipoParameter = idNomina_Tipo.HasValue ?
                new ObjectParameter("IdNomina_Tipo", idNomina_Tipo) :
                new ObjectParameter("IdNomina_Tipo", typeof(int));
    
            var idNomina_TipoLiquiParameter = idNomina_TipoLiqui.HasValue ?
                new ObjectParameter("IdNomina_TipoLiqui", idNomina_TipoLiqui) :
                new ObjectParameter("IdNomina_TipoLiqui", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRo_Cierre_Rol", idEmpresaParameter, idPeriodoParameter, idNomina_TipoParameter, idNomina_TipoLiquiParameter);
        }
    
        public virtual int spRo_Reverso_Rol(Nullable<int> idEmpresa, Nullable<int> idNomina_Tipo, Nullable<int> idNomina_TipoLiqui, Nullable<int> idPeriodo)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idNomina_TipoParameter = idNomina_Tipo.HasValue ?
                new ObjectParameter("IdNomina_Tipo", idNomina_Tipo) :
                new ObjectParameter("IdNomina_Tipo", typeof(int));
    
            var idNomina_TipoLiquiParameter = idNomina_TipoLiqui.HasValue ?
                new ObjectParameter("IdNomina_TipoLiqui", idNomina_TipoLiqui) :
                new ObjectParameter("IdNomina_TipoLiqui", typeof(int));
    
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRo_Reverso_Rol", idEmpresaParameter, idNomina_TipoParameter, idNomina_TipoLiquiParameter, idPeriodoParameter);
        }
    
        public virtual int spROL_DecimoCuarto(Nullable<int> idEmpresa, Nullable<int> idPeriodo, string region, string idUsuario, string observacion, Nullable<int> idRol)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            var regionParameter = region != null ?
                new ObjectParameter("Region", region) :
                new ObjectParameter("Region", typeof(string));
    
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(string));
    
            var observacionParameter = observacion != null ?
                new ObjectParameter("observacion", observacion) :
                new ObjectParameter("observacion", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spROL_DecimoCuarto", idEmpresaParameter, idPeriodoParameter, regionParameter, idUsuarioParameter, observacionParameter, idRolParameter);
        }
    
        public virtual int spROL_DecimoTercero(Nullable<int> idEmpresa, Nullable<int> idPeriodo, string region, string idUsuario, string observacion, Nullable<int> idRol)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idPeriodoParameter = idPeriodo.HasValue ?
                new ObjectParameter("IdPeriodo", idPeriodo) :
                new ObjectParameter("IdPeriodo", typeof(int));
    
            var regionParameter = region != null ?
                new ObjectParameter("Region", region) :
                new ObjectParameter("Region", typeof(string));
    
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(string));
    
            var observacionParameter = observacion != null ?
                new ObjectParameter("observacion", observacion) :
                new ObjectParameter("observacion", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spROL_DecimoTercero", idEmpresaParameter, idPeriodoParameter, regionParameter, idUsuarioParameter, observacionParameter, idRolParameter);
        }
    
        public virtual int spRo_procesa_Rol(Nullable<int> idEmpresa, Nullable<decimal> idNomina, Nullable<decimal> idNominaTipo, Nullable<decimal> idPEriodo, string idUsuario, string observacion, Nullable<int> idRol, Nullable<int> idSucursalInicio, Nullable<int> idSucursalFin)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idNominaParameter = idNomina.HasValue ?
                new ObjectParameter("IdNomina", idNomina) :
                new ObjectParameter("IdNomina", typeof(decimal));
    
            var idNominaTipoParameter = idNominaTipo.HasValue ?
                new ObjectParameter("IdNominaTipo", idNominaTipo) :
                new ObjectParameter("IdNominaTipo", typeof(decimal));
    
            var idPEriodoParameter = idPEriodo.HasValue ?
                new ObjectParameter("IdPEriodo", idPEriodo) :
                new ObjectParameter("IdPEriodo", typeof(decimal));
    
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(string));
    
            var observacionParameter = observacion != null ?
                new ObjectParameter("Observacion", observacion) :
                new ObjectParameter("Observacion", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            var idSucursalInicioParameter = idSucursalInicio.HasValue ?
                new ObjectParameter("IdSucursalInicio", idSucursalInicio) :
                new ObjectParameter("IdSucursalInicio", typeof(int));
    
            var idSucursalFinParameter = idSucursalFin.HasValue ?
                new ObjectParameter("IdSucursalFin", idSucursalFin) :
                new ObjectParameter("IdSucursalFin", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRo_procesa_Rol", idEmpresaParameter, idNominaParameter, idNominaTipoParameter, idPEriodoParameter, idUsuarioParameter, observacionParameter, idRolParameter, idSucursalInicioParameter, idSucursalFinParameter);
        }
    
        public virtual ObjectResult<spROL_DecimosCSV_Result> spROL_DecimosCSV(Nullable<int> idEmpresa, Nullable<int> idRol, Nullable<int> idRubro)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            var idRubroParameter = idRubro.HasValue ?
                new ObjectParameter("IdRubro", idRubro) :
                new ObjectParameter("IdRubro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spROL_DecimosCSV_Result>("spROL_DecimosCSV", idEmpresaParameter, idRolParameter, idRubroParameter);
        }
    
        public virtual int spRo_procesa_Rol_bono(Nullable<int> idEmpresa, Nullable<decimal> idNomina, Nullable<decimal> idNominaTipo, Nullable<decimal> idPEriodo, string idUsuario, string observacion, Nullable<int> idRol)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idNominaParameter = idNomina.HasValue ?
                new ObjectParameter("IdNomina", idNomina) :
                new ObjectParameter("IdNomina", typeof(decimal));
    
            var idNominaTipoParameter = idNominaTipo.HasValue ?
                new ObjectParameter("IdNominaTipo", idNominaTipo) :
                new ObjectParameter("IdNominaTipo", typeof(decimal));
    
            var idPEriodoParameter = idPEriodo.HasValue ?
                new ObjectParameter("IdPEriodo", idPEriodo) :
                new ObjectParameter("IdPEriodo", typeof(decimal));
    
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(string));
    
            var observacionParameter = observacion != null ?
                new ObjectParameter("Observacion", observacion) :
                new ObjectParameter("Observacion", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRo_procesa_Rol_bono", idEmpresaParameter, idNominaParameter, idNominaTipoParameter, idPEriodoParameter, idUsuarioParameter, observacionParameter, idRolParameter);
        }
    
        public virtual int spRo_procesa_Rol_anticipo(Nullable<int> idEmpresa, Nullable<decimal> idNomina, Nullable<decimal> idNominaTipo, Nullable<decimal> idPEriodo, string idUsuario, string observacion, Nullable<int> idRol, Nullable<int> idSucursalInicio, Nullable<int> idSucursalFin)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idNominaParameter = idNomina.HasValue ?
                new ObjectParameter("IdNomina", idNomina) :
                new ObjectParameter("IdNomina", typeof(decimal));
    
            var idNominaTipoParameter = idNominaTipo.HasValue ?
                new ObjectParameter("IdNominaTipo", idNominaTipo) :
                new ObjectParameter("IdNominaTipo", typeof(decimal));
    
            var idPEriodoParameter = idPEriodo.HasValue ?
                new ObjectParameter("IdPEriodo", idPEriodo) :
                new ObjectParameter("IdPEriodo", typeof(decimal));
    
            var idUsuarioParameter = idUsuario != null ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(string));
    
            var observacionParameter = observacion != null ?
                new ObjectParameter("Observacion", observacion) :
                new ObjectParameter("Observacion", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            var idSucursalInicioParameter = idSucursalInicio.HasValue ?
                new ObjectParameter("IdSucursalInicio", idSucursalInicio) :
                new ObjectParameter("IdSucursalInicio", typeof(int));
    
            var idSucursalFinParameter = idSucursalFin.HasValue ?
                new ObjectParameter("IdSucursalFin", idSucursalFin) :
                new ObjectParameter("IdSucursalFin", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRo_procesa_Rol_anticipo", idEmpresaParameter, idNominaParameter, idNominaTipoParameter, idPEriodoParameter, idUsuarioParameter, observacionParameter, idRolParameter, idSucursalInicioParameter, idSucursalFinParameter);
        }
    }
}
