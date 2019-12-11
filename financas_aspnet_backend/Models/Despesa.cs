using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace financas_aspnet_backend.Models
{
    [Table("Despesas")]
    public class Despesa
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo 'Descrição' é obrigatório!")]
        public string Descricao { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Campo 'Data' é obrigatório!")]
        public DateTime Data { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Campo 'Valor' é obrigatório!")]
        public double Valor { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Campo 'Categoria' é obrigatório!")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
    }
}
