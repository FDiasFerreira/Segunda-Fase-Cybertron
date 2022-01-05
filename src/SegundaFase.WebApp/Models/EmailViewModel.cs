using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SegundaFase.WebApp.Models
{
    public class EmailViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime InsertDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateDate { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
           MinimumLength = 5)]
        [DisplayName("E-mail")]
        public string EmailAddress { get; set; }

        public SupplierViewModel Supplier { get; set; }

        [HiddenInput]
        public Guid SupplierId { get; set; }

    }
}
