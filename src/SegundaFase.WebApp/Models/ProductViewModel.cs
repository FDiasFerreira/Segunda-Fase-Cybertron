using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SegundaFase.WebApp.Models
{
    public class ProductViewModel
    {
        [Key]
        public Guid Id { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime InsertDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateDate { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatóro")]
        [DisplayName("Fornecedor")]
        public SupplierViewModel Supplier { get; set; }

        public IEnumerable<SupplierViewModel> Suppliers { get; set; }
        
        [HiddenInput]
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Categoria")]   
        public CategoryViewModel Category { get; set; }

        [HiddenInput]
        public Guid CategoryId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", 
            MinimumLength = 2)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(13, ErrorMessage = "O campo {0} precisa ter 13 caracteres")]
        [DisplayName("Código de Barras")]
        public string BarCode { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Quantidade em Estoque")]
        public int QuantityStock { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Preço de Venda")]
        public decimal PriceSales { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Preço de Compra")]
        public decimal PricePurchase { get; set; }

        [DisplayName("Imagens")]
        public ICollection<ImageViewModel> Images { get; set; } = new List<ImageViewModel>();

        public IFormFile ImageUpload { get; set; }
    }
}
