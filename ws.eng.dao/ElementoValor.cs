//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ws.eng.dao
{
    using System;
    using System.Collections.Generic;
    
    public partial class ElementoValor
    {
        public int ID { get; set; }
        public int ElementoID { get; set; }
        public int PaisID { get; set; }
        public decimal Valor { get; set; }
        public Nullable<System.DateTime> VigenciaFim { get; set; }
    
        public virtual Elemento Elemento { get; set; }
        public virtual Pai Pai { get; set; }
    }
}