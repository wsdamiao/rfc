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
    
    public partial class Distancia
    {
        public int ID { get; set; }
        public int LogradouroID { get; set; }
        public decimal Valor { get; set; }
        public Nullable<System.DateTime> VigenciaFim { get; set; }
    }
}