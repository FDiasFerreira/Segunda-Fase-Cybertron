using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SegundaFase.Business.Interfaces;
using SegundaFase.WebApp.Models;


namespace SegundaFase.WebApp.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProductRepository _productRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository productRepository, 
                                  ISupplierRepository supplierRepository,
                                  IMapper mapper)
        {
            _productRepository = productRepository;
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProductViewModel>>(await _productRepository.
                ObterProdutosSuppliers()));
        }

        public async Task<IActionResult> Details (Guid id)
        {
            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)
            {
                return NotFound();
            }
            return View(produtoViewModel);
        }

        public async Task<IActionResult> Create()
        {
            var productViewModel = await PopularSuppliers(new ProductViewModel());
            return View(productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductViewModel productViewModel)
        {
            productViewModel = await PopularSuppliers(productViewModel);
            if (!ModelState.IsValid) return View(productViewModel);

            await _productRepository.Adicionar(_mapper.Map<Product>(productViewModel));

            return View(productViewModel);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var productViewModel = await ObterProduto(id);
            if(productViewModel == null)
            {
                return NotFound();
            }
            return View(productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ProductViewModel productViewModel)
        {
            if (id != productViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(productViewModel);
            await _productRepository.Atualizar(_mapper.Map<Product>(productViewModel));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var product = await ObterProduto(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var product = await ObterProduto(id);
            if (product == null)
            {
                return NotFound();
            }
            await _productRepository.Remover(id);
            return RedirectToAction("Index");
        }

        private async Task<ProductViewModel> ObterProduto(Guid id)
        {
            //Obtem produto e o fornecedor dele
            var product = _mapper.Map<ProductViewModel>(await _productRepository
                .ObterProdutoSupplier(id));
            product.Suppliers = _mapper.Map<IEnumerable<SupplierViewModel>>
                (await _supplierRepository.ObterTodos());
            return product;
        }

        private async Task<ProductViewModel> PopularSuppliers(ProductViewModel product)
        {           
            product.Suppliers = _mapper.Map<IEnumerable<SupplierViewModel>>
                (await _supplierRepository.ObterTodos());
            return product;
        }
    }
}
