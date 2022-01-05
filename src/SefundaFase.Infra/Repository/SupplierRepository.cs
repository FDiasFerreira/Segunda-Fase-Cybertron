using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SegundaFase.Business.Interfaces;
using SegundaFase.Data.Context;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Repository
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(AppDbContext context) : base(context) { }

        public async Task<Supplier> ObterSupplierEnderecoTelefoneEmail(Guid id)
        {
            return await App.Suppliers.AsNoTracking()
                        .Include(c => c.Address)
                        .Include(c => c.Phones)
                        .Include(c => c.Email)
                        .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Supplier> ObterSupplierProdutosEndereçoTelefonesEmail(Guid id)
        {
            return await App.Suppliers.AsNoTracking()
                        .Include(c => c.Products)
                        .Include(c => c.Address)
                        .Include(c => c.Phones)
                        .Include(c => c.Email)
                        .FirstOrDefaultAsync(c => c.Id == id);

        }
    }
}
