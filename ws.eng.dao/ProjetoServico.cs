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
    
    public partial class ProjetoServico
    {
        public int ID { get; set; }
        public int ProjetoID { get; set; }
        public int ServicoID { get; set; }
        public decimal Valor { get; set; }
        public System.DateTime Data { get; set; }
        public int Status { get; set; }
        public string Descricao { get; set; }
        public int UsuarioID { get; set; }
        public Nullable<int> FormaPgto { get; set; }
        public Nullable<decimal> T { get; set; }
        public Nullable<decimal> A { get; set; }
        public Nullable<decimal> P { get; set; }
        public Nullable<decimal> d { get; set; }
    
        public virtual Projeto Projeto { get; set; }
    }
}
