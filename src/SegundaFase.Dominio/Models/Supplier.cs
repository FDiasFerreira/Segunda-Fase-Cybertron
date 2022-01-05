using System.Collections.Generic;
using SegundaFase.Business;
using SegundaFase.Business.Models;
using SegundaFase.Business.Models.Enums;

namespace SegundaFase.WebApp.Models
{
    public abstract class Supplier : Entity
    { 
        public string FantasyName { get; private set; }
        public bool Active { get; private set; }

        public SupplierType SupplierType { get; set; }
        public Address Address { get; set; }
        public Email Email { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();

        public ICollection<Phone> Phones { get; set; } = new List<Phone>();
     

        protected  Supplier() { }        

                  
            
        public Supplier(string fantasyName,
                        bool active,
                        SupplierType supplierType,
                        string ddd,
                        string number,
                        PhoneType phoneType,
                        Address address,
                        Email email)
            {
                FantasyName = fantasyName;
                Active = active;
                SupplierType = supplierType;

                AddPhone(ddd, number, phoneType);

                Address = address;
                Email = email;
            }
          
        public virtual void AddPhone(string ddd, string number, PhoneType phoneType)
        {
            if (Phones.Count >= 3) throw new DomainException("É permitido no máximo 3 telefones.");
            Phones.Add(new Phone(this, ddd, number, phoneType));
        }

     
    }


}
