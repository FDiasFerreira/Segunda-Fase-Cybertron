using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SegundaFase.Business.Interfaces;
using SegundaFase.Data.Context;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context) { }
        
        public async Task<IEnumerable<Product>> ObterProdutosPorSupplier(Guid supplierId)
        {
            return await Buscar(p => p.SupplierId == supplierId);
        }

        public async Task<IEnumerable<Product>> ObterProdutosSuppliers()
        {
            return await App.Products.AsNoTracking().Include(s => s.Supplier)
                .OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<Product> ObterProdutoSupplier(Guid id)
        {
            return await App.Products.AsNoTracking().Include(s => s.Supplier)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
