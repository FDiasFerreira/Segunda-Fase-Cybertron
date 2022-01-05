using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SegundaFase.Business.Interfaces;

namespace SegundaFase.WebApp.Controllers
{
    public class AddressController : BaseController
    {
        private readonly IAddressRepository _addressRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public AddressController(IAddressRepository addressRepository, ISupplierRepository supplierRepository, 
                                IMapper mapper)
        {
            _addressRepository = addressRepository;
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
