using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SegundaFase.Business.Interfaces;
using SegundaFase.Data.Context;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Repository
{
    public class EmailRepository : Repository<Email>, IEmailRepository 
    {
        public EmailRepository(AppDbContext context) : base(context) { }

        public async Task<Email> ObterEmailPorFornecedor(Guid supplierId)
        {
            return await App.Emails.AsNoTracking()
                 .FirstOrDefaultAsync(s => s.SupplierId == supplierId);
        }
    }
}
