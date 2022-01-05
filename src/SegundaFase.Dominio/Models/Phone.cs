using System;
using SegundaFase.Business.Models;
using SegundaFase.Business.Models.Enums;

namespace SegundaFase.WebApp.Models
{
    public class Phone : Entity
    {        
        public Guid SupplierId { get; private set; }

        public string Ddd { get; private set; }
        public string Number { get; private set; }
        public PhoneType PhoneType { get; private set; }

        public Supplier Supplier { get; private set; }

        protected Phone() { }

        public Phone(Supplier supplier, string ddd, string number, PhoneType phoneType)
        {
            SupplierId = supplier.Id;
            Supplier = supplier;

            Ddd = ddd;
            Number = number;
            PhoneType = phoneType;
        }

    }
}
