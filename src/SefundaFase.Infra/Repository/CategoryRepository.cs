using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SegundaFase.Business.Interfaces;
using SegundaFase.Data.Context;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Category>> ObterCategorias()
        {
            return await App.Categories.AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<Category>> ObterProdutosCategoria(Guid categoryId)
        {
            return await App.Categories.AsNoTracking().Include(p => p.Products)
               .ToListAsync();
        }
    }
}
