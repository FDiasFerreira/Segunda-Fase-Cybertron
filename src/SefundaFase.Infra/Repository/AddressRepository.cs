using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SegundaFase.Business.Interfaces;
using SegundaFase.Data.Context;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext context) : base(context) { }

        public async Task<Address> ObterEnderecoPorSupplier(Guid supplierId)
        {
            return await App.Addresses.AsNoTracking()
                .FirstOrDefaultAsync(s => s.SupplierId == supplierId);
        }
    }
}
