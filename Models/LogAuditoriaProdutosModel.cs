using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengerKenner1._0.Models
{
    [Table("LogAuditoriaProdutos")]
    public class LogAuditoriaProdutosModel
    {
        [Key]
        [Column("IdLogProdutos")]
        [Display(Name = "Código")]
        public Guid LogProdutosId { get; set; }

        [Column("DetalhesAuditoriaProdutos")]
        [Display(Name = "Detalhes Auditoria Produtos")]
        public string DetalhesAuditoriaProdutos { get; set; }

        [Column("EmailUsuarioProdutos")]
        [Display(Name = "Email ")]
        public string EmailUsuario { get; set; }


    }
}
