using System;
using SegundaFase.Business.Models;

namespace SegundaFase.WebApp.Models
{
    public class Email : Entity
    {       
        public Guid SupplierId { get; private set; }

        public string EmailAddress { get; private set; }

        public Supplier Supplier { get; private set; }

        protected Email() { }

        public Email(Supplier supplier, string emailAddress)
        {
            SupplierId = supplier.Id;
            Supplier = supplier;

            EmailAddress = emailAddress;
        }
    }
}
