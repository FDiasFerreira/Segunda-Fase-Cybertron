using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> ObterProdutosPorSupplier(Guid supplierId);
        Task<IEnumerable<Product>> ObterProdutosSuppliers(); //Lista de produtos e fornecedores desse produto
        Task<Product> ObterProdutoSupplier(Guid id); //Obter 1 produto do fornecedor
    }
}
