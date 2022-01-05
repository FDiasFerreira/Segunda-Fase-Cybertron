using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SegundaFase.Business.Interfaces;
using SegundaFase.WebApp.Models;


namespace SegundaFase.WebApp.Controllers
{

    public class SuppliersController : BaseController
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public SuppliersController(ISupplierRepository supplierRepository,
                                 IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<SupplierViewModel>>(await _supplierRepository
                .ObterTodos()));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var supplierViewModel = await ObterSupplierEnderecoTelefoneEmail(id);

            if(supplierViewModel == null)
            {
                return NotFound();
            }

            return View(supplierViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SupplierViewModel supplierViewModel)
        {
            if (!ModelState.IsValid) return View(supplierViewModel);

            var supplier = _mapper.Map<Supplier>(supplierViewModel);
            await _supplierRepository.Adicionar(supplier);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var supplierViewModel = await ObterSupplierEnderecoTelefoneEmail(id);

            if(supplierViewModel == null)
            {
                return NotFound();
            }

            return View(supplierViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var supplierViewModel = await ObterSupplierEnderecoTelefoneEmail(id);

            if (supplierViewModel == null) return NotFound();

            await _supplierRepository.Remover(id);

            return RedirectToAction("Index");
        }


        public async Task<SupplierViewModel> ObterSupplierEnderecoTelefoneEmail(Guid id)
        {
            return _mapper.Map<SupplierViewModel>(await _supplierRepository
                .ObterSupplierProdutosEndereçoTelefonesEmail(id));
        }
    }
}
