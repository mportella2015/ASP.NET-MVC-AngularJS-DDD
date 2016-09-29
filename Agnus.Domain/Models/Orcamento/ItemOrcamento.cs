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
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    [Table("ItemOrcamento")]
    public partial class ItemOrcamento : KeyAuditableEntity
    {
        public ItemOrcamento()
        {
            this.OrcamentoAtual = new HashSet<OrcamentoAtual>();
        }

        public string NomeFase { get; set; }
        public string NomeEtapa { get; set; }
        public string CodGrupo { get; set; }
        public string NomeGrupo { get; set; }
        public string CodItem { get; set; }
        public string NomeItem { get; set; }
        public decimal? Percentual { get; set; }

        [ForeignKey("ItemPlanoContas")]
        public long IdItemPlanoContas { get; set; }
        public virtual ItemPlanoContas ItemPlanoContas { get; set; }

        [ForeignKey("ProjetoOrcamento")]
        public long IdProjetoOrcamento { get; set; }
        public virtual ProjetoOrcamento ProjetoOrcamento { get; set; }

        public virtual ICollection<OrcamentoAtual> OrcamentoAtual { get; set; }

        public OrcamentoAtual GetOrcamentoAtualPorData(int mes, int ano)
        {
            return this.OrcamentoAtual.FirstOrDefault(x => x.NumMes == mes && x.NumAno == ano);
        }
    }
}
