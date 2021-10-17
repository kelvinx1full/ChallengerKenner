using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengerKenner1._0.Models
{
    [Table("Produto")]
    public class ProdutoModel
    {
        [Key]
        [Column("ProdutoId")]
        [Display(Name ="Codigo")]
        public Guid ProdutoId { get; set; }

        [Column("Nome")]
        [Display(Name ="Nome")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Informe o nome do produto")]
        public string Nome { get; set; }

        [MaxLength(100)]
        public string Descricao { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        [Required(ErrorMessage = "Informe o custo")]
        public decimal Custo { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        [Required(ErrorMessage = "Informe o valor unitario")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Informe a quantidade")]
        public double Quantidade { get; set; }
    }
}
