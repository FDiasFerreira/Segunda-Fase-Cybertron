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
    public class PhoneRepository : Repository<Phone>, IPhoneRepository
    {
        public PhoneRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Phone>> ObterTelefonesSupplier(Guid supplierId)
        {
            return await App.Phones.AsNoTracking().Include(s => s.Supplier)
                .ToListAsync();
        }
    }
}
