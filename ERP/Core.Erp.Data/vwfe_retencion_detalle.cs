//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwfe_retencion_detalle
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetencion { get; set; }
        public int Idsecuencia { get; set; }
        public string re_tipoRet { get; set; }
        public Nullable<decimal> baseRetencion { get; set; }
        public int IdCodigo_SRI { get; set; }
        public string re_Codigo_impuesto { get; set; }
        public double re_Porcen_retencion { get; set; }
        public Nullable<decimal> re_valor_retencion { get; set; }
    }
}
