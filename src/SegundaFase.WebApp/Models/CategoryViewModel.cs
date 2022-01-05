using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundaFase.WebApp.Models
{
    public class CategoryViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime InsertDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateDate { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
           MinimumLength = 2)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        public ICollection<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
    }
}
