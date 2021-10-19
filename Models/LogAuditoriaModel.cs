using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengerKenner1._0.Models
{
    [Table("LogAuditoria")]
    public class LogAuditoriaModel
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Column("DetalhesAuditoria")]
        [Display(Name = "Detalhes Relatório Geral")]
        public string DetalhesAuditoria { get; set; }

        [Column("EmailUsuario")]
        [Display(Name = "Email")]
        public string EmailUsuario { get; set; }
    }
}
