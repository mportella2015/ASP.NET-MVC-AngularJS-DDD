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

    [Table("ModeloAICP")]
    public partial class ModeloAICP : KeyAuditableEntity
    {
        public ModeloAICP()
        {
            this.TemplateItems = new HashSet<TemplateItem>();
        }

        public string Nome { get; set; }

        public virtual ICollection<TemplateItem> TemplateItems { get; set; }
    }
}
