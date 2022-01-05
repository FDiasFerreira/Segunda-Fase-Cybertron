//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using SegundaFase.Business.Interfaces;
//using SegundaFase.Data.Context;
//using SegundaFase.WebApp.Models;

//namespace SegundaFase.Data.Repository
//{
//    public class SupplierJuridicalRepository : Repository<SupplierJuridical>,
//        ISupplierJuridicalRepository
//    {
//        public SupplierJuridicalRepository(AppDbContext context) : base(context) { }

//        public async Task<Supplier> ObterSupplierEmail(Guid id)
//        {
//            return await App.Suppliers.AsNoTracking()
//                .Include(c => c.Email)
//                .FirstOrDefaultAsync(c => c.Id == id);

//        }

//        public async Task<Supplier> ObterSupplierEndereco(Guid id)
//        {
//            return await App.Suppliers.AsNoTracking()
//                .Include(c => c.Address)
//                .FirstOrDefaultAsync(c => c.Id == id);

//        }

//        async Task<IEnumerable<Supplier>> ISupplierJuridicalRepository.ObterSupplierTelefones(Guid id)
//        {
//            return (IEnumerable<Supplier>)await App.Phones.AsNoTracking().Include(s => s.Supplier)
//               .ToListAsync();
//        }

//        public async Task<Supplier> ObterSupplierProdutosEndereçoTelefonesEmail(Guid id)
//        {
//            return await App.Suppliers.AsNoTracking()
//                .Include(c => c.Products)
//                .Include(c => c.Address)
//                .Include(c => c.Phones)
//                .Include(c => c.Email)
//                .FirstOrDefaultAsync(c => c.Id == id);
//        }
//    }
//}
