using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Interfaces
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<Address> ObterEnderecoPorSupplier(Guid supplierId);
    }
}
