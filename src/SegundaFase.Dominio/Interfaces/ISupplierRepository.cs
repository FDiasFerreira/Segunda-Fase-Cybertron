using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Interfaces
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        Task<Supplier> ObterSupplierEnderecoTelefoneEmail(Guid id);
       
        Task<Supplier> ObterSupplierProdutosEndereçoTelefonesEmail(Guid id);
    }
}
