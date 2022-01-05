using System;
using SegundaFase.Business.Models;

namespace SegundaFase.WebApp.Models
{
    public class Image : Entity
    {
        public string ImagePath { get; private set; }

        public Product Product { get; private set; }
        public Guid ProductId { get; private set; }
        

        protected Image() { }

        public Image(Product product, string imagePath)
        {
            ProductId = product.Id;
            Product = product;
           
            ImagePath = imagePath;
            
        }

        

    }
}
