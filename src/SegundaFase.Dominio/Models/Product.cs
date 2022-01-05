using System;
using System.Collections.Generic;
using SegundaFase.Business;
using SegundaFase.Business.Models;

namespace SegundaFase.WebApp.Models
{
    public class Product : Entity
    {        
        public Guid SupplierId { get; private set; }                
        public Guid CategoryId { get; private set; }

        public string Name { get; private set; }
        public string BarCode { get; private set; }
        public int QuantityStock { get; private set; }
        public bool Active { get; private set; }
        public decimal PriceSales { get; private set; }
        public decimal PricePurchase { get; private set; }

        public Supplier Supplier { get; private set; }
        public Category Category { get; set; }
        public ICollection<Image> Images { get; set; } = new List<Image>();
      

        protected Product() { }

        public Product(string name, string barCode, int quantityStock, 
            bool active, decimal priceSales, decimal pricePurchase, 
            Supplier supplier, Category category, string imagePath)
        {
            SupplierId = supplier.Id;
            Supplier = supplier;
            CategoryId = category.Id;
            Category = category;

            Name = name;
            BarCode = barCode;
            QuantityStock = quantityStock;
            Active = active;
            PriceSales = priceSales;
            PricePurchase = pricePurchase;
            
            AddImages(imagePath);
        }

        public void AddImages(string imagePath)
        {
            if (Images.Count >= 5) throw new DomainException("São permitidas no máximo 5 imagens.");
            Images.Add(new Image(this, imagePath));
        }


    }
}
