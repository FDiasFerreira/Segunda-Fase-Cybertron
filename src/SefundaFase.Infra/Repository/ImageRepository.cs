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
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Image>> ObterImagens(Guid productId)
        {
            return await App.Images.ToListAsync();
        }
    }
}
