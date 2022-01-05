using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SegundaFase.WebApp.Models
{
    public class ImageViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime InsertDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateDate { get;set; }

        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",
            MinimumLength = 2)]
        public string ImagePath { get; set; }

        public ProductViewModel Product { get; set; }

        [HiddenInput]
        public Guid ProductId { get; set; }
    }
}
