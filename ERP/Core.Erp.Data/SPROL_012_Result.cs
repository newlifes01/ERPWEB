//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    
    public partial class SPROL_012_Result
    {
        public int IdEmpresa { get; set; }
        public int IdDepartamento { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdPrestamo { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string EstadoPago { get; set; }
        public string de_descripcion { get; set; }
        public Nullable<double> Total_Prestamo { get; set; }
        public Nullable<double> Total_Cancelado { get; set; }
        public Nullable<double> Total_Pendiente_pago { get; set; }
        public string Observacion { get; set; }
        public System.DateTime Fecha_PriPago { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public int IdSucursal { get; set; }
    }
}
