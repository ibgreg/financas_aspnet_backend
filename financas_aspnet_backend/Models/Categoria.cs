using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace financas_aspnet_backend.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Display(Name ="Descrição")]
        [Required(ErrorMessage ="Campo 'Descrição' é obrigatório!")]
        public string Descricao { get; set; }

        public ICollection<Despesa> Despesas { get; set; }
    }
}
