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
    
    public partial class fa_TerminoPago
    {
        public fa_TerminoPago()
        {
            this.fa_cliente = new HashSet<fa_cliente>();
            this.fa_proforma = new HashSet<fa_proforma>();
            this.fa_TerminoPago_Distribucion = new HashSet<fa_TerminoPago_Distribucion>();
        }
    
        public string IdTerminoPago { get; set; }
        public string nom_TerminoPago { get; set; }
        public int Num_Coutas { get; set; }
        public int Dias_Vct { get; set; }
        public bool estado { get; set; }
    
        public virtual ICollection<fa_cliente> fa_cliente { get; set; }
        public virtual ICollection<fa_proforma> fa_proforma { get; set; }
        public virtual ICollection<fa_TerminoPago_Distribucion> fa_TerminoPago_Distribucion { get; set; }
    }
}
