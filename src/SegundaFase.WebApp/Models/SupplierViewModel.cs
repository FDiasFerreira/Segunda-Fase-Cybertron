using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SegundaFase.WebApp.Models;

namespace SegundaFase.WebApp.Models
{
    public class SupplierViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime InsertDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateDate { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
           MinimumLength = 2)]
        [DisplayName("Nome Fantasia")]
        public string FantasyName { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Tipo de Fornecedor")]
        public SupplierType SupplierType { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Endereço")]
        public AddressViewModel Address { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public EmailViewModel Email { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();

        public IEnumerable<PhoneViewModel> Phones { get; set; } = new List<PhoneViewModel>();
    }
}
