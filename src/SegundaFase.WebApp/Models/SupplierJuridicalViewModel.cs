using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundaFase.WebApp.Models
{
    public class SupplierJuridicalViewModel
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
        [DisplayName("Nome da Empresa")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
           MinimumLength = 2)]
        [DisplayName("Nome Fantasia")]
        public string FantasyName { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter 14 caracteres")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Data de Abertura")]
        public DateTime OpenDate { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Endereço")]
        public AddressViewModel Address { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public EmailViewModel Email { get; set; }

        public ICollection<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();

        public ICollection<PhoneViewModel> Phones { get; set; } = new List<PhoneViewModel>();
    }
}
