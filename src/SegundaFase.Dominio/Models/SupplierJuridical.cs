using System;
using SegundaFase.Business.Models;
using SegundaFase.Business.Models.Enums;

namespace SegundaFase.WebApp.Models
{
    public class SupplierJuridical : Supplier
    {
        public string CompanyName { get; set; }
        public string CNPJ { get; set; }
        public DateTime OpenDate { get; set; }

        
        protected SupplierJuridical() { }


        public SupplierJuridical(string fantasyName,
                                bool active,
                                SupplierType supplierType,
                                string companyName,
                                string cnpj,
                                DateTime openDate,
                                string ddd,
                                string number,
                                PhoneType phoneType,
                                Address address,
                                Email email) : base(fantasyName, active, supplierType, ddd, number, phoneType, address, email)
        {
            CompanyName = companyName;
            OpenDate = openDate;
        }

        public override void AddPhone(string ddd, string number, PhoneType phoneType)
        {
            base.AddPhone(ddd, number, phoneType);
        }



    }
}
