//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class vwcp_retencion_det
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetencion { get; set; }
        public int Idsecuencia { get; set; }
        public string re_tipoRet { get; set; }
        public double re_baseRetencion { get; set; }
        public int IdCodigo_SRI { get; set; }
        public string re_Codigo_impuesto { get; set; }
        public double re_Porcen_retencion { get; set; }
        public double re_valor_retencion { get; set; }
        public string re_estado { get; set; }
        public string IdCtaCble { get; set; }
    }
}
