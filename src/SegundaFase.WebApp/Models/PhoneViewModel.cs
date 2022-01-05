using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SegundaFase.Business.Models.Enums;

namespace SegundaFase.WebApp.Models
{
    public class PhoneViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime InsertDate { get;  set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateDate { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(2, ErrorMessage = "O campo {0} precisa ter 2 caracteres")]
        public string Ddd { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(9, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
          MinimumLength = 8)]
        [DisplayName("Número de Telefone")]
        public string Number { get; set; }

        public int PhoneType { get; set; } //Não precisa ser Enum na ViewModel, pode ser int


        public SupplierViewModel Supplier { get; set; }

        [HiddenInput]
        public Guid SupplierId { get; set; }

    }
}
