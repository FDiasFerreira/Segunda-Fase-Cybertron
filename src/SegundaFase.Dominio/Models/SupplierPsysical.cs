using System;
using SegundaFase.Business.Models.Enums;

namespace SegundaFase.WebApp.Models
{
    public class SupplierPhysical : Supplier
    {
        public string FullName { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }


        protected SupplierPhysical() { }

        public SupplierPhysical(string fantasyName,
                                bool active,
                                SupplierType supplierType,
                                string fullName,
                                string cpf,
                                DateTime birthDate,
                                string ddd,
                                string number,
                                PhoneType phoneType,
                                Address address,
                                Email email) : base(fantasyName, active, supplierType, ddd, number, phoneType, address, email)
        {
            FullName = fullName;
            BirthDate = birthDate;

            AddPhone(ddd, number, phoneType);
        }

        public override void AddPhone(string ddd, string number, PhoneType phoneType)
        {
            base.AddPhone(ddd, number, phoneType);
        }
    }
}
