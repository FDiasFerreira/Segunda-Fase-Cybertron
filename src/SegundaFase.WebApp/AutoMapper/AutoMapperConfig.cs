using AutoMapper;
using SegundaFase.WebApp.Models;


namespace SegundaFase.WebApp.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Supplier, SupplierViewModel>().ReverseMap();
            CreateMap<SupplierJuridical, SupplierJuridicalViewModel>().ReverseMap();
            CreateMap<SupplierPhysical, SupplierPhysicalViewModel>().ReverseMap();
            CreateMap<Address, AddressViewModel>().ReverseMap();
            CreateMap<Phone, PhoneViewModel>().ReverseMap();
            CreateMap<Email, EmailViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Image, ImageViewModel>().ReverseMap();
        }
    }
}
