//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agnus.Domain.Models
{
    using Agnus.Domain;
    using Agnus.Domain.Models;
    using Agnus.Domain.Models.Enum;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using System.Linq;

    [Table("ProjetoPessoa")]
    [DataContract]
    public partial class ProjetoPessoa : KeyAuditableEntity, ILogProjeto
    {
        //public long Id { get; set; }
        [DataMember]
        public DateTime? DataInicio { get; set; }
        [DataMember]
        public DateTime? DataFim { get; set; }

        [ForeignKey("Papel")]
        [DataMember]
        public long IdPapel { get; set; }
        public virtual ConteudoTabelaDominio Papel { get; set; }

        [ForeignKey("Pessoa")]
        [DataMember]
        public long? IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        [ForeignKey("Projeto")]
        [DataMember]
        public long IdProjeto { get; set; }
        public virtual Projeto Projeto { get; set; }

        [NotMapped]
        public string NomeEntidade
        {
            get { return "Pessoa"; }
        }

        public decimal ValPercentualAtendimento { get; set; }        

        public bool IsPessoaAtivaVigente() 
        {
            return !this.DataFim.HasValue;
        }

        public bool IsPessoaAtivaPapel(DateTime dataInicio)
        {
            return this.IsPessoaAtivaVigente() || (this.DataFim.HasValue && this.DataFim.Value > dataInicio);
        }
    }
}
