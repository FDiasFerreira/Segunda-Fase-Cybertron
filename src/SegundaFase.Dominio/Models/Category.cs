using System.Collections.Generic;
using SegundaFase.Business.Models;

namespace SegundaFase.WebApp.Models
{
    public class Category : Entity
    {    
        public string Name { get; private set; }
        public bool Active { get; private set; }        

        public ICollection<Product> Products { get; set; } = new List<Product>();

        protected Category() { }

        public Category(bool active, string name)
        {
            Active = active;
            Name = name;
        }
    }
}
