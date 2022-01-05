using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SegundaFase.WebApp.Models
{
    public class AddressViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime InsertDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateDate { get; set; }

        public SupplierViewModel Supplier { get; set; }

        [HiddenInput]
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(9, ErrorMessage = "O campo {0} precisa ter 9 caracteres")]
        [DisplayName("CEP")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
           MinimumLength = 5)]
        [DisplayName("Rua")]
        public string Street { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
           MinimumLength =1)]
        [DisplayName("Número")]
        public string Number { get; set; }

        public string Complement { get; set; }

        public string Reference { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
                  MinimumLength = 2)]
        [DisplayName("Bairro")]
        public string Neighborhood { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
                  MinimumLength = 2)]
        [DisplayName("Cidade")]
        public string City { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
                  MinimumLength = 2)]
        [DisplayName("Estado")]
        public string State { get;  set; }
    }
}
