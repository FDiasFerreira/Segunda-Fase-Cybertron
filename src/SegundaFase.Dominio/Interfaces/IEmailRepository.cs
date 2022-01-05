using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Interfaces
{
    public interface IEmailRepository : IRepository<Email>
    {
        Task<Email> ObterEmailPorFornecedor(Guid supplierId);
    }
}
