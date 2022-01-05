using System;
using SegundaFase.Business.Models;

namespace SegundaFase.WebApp.Models
{
    public class Address : Entity
    {
        
        public Guid SupplierId { get; private set; }

        public string ZipCode { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string Reference { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

        public Supplier Supplier { get; private set; }
        protected Address() { }

        public Address(Supplier supplier, string zipCode, string street, string number, string complement, 
            string reference, string neighborhood, string city, string state)
        {
            SupplierId = supplier.Id;
            Supplier = supplier;

            ZipCode = zipCode;
            Street = street;
            Number = number;
            Complement = complement;
            Reference = reference;
            Neighborhood = neighborhood;
            City = city;
            State = state;
        }
    }
}
