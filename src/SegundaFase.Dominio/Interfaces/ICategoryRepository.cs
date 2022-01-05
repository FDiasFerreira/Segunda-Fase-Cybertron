using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IEnumerable<Category>> ObterCategorias();
        Task<IEnumerable<Category>> ObterProdutosCategoria(Guid categoryId);
    }
}
