﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.DTO.Dtos.ProductDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;

		public ProductController(IProductService productService, IMapper mapper)
		{
			_productService=productService;
			_mapper=mapper;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _productService.TGetListAsync();
			var valueList = _mapper.Map<List<ResultProductDto>>(values);
			return View(valueList);
		}
		public async Task<IActionResult> DeleteProduct(int id)
		{
			await _productService.TDeleteAsync(id);
			return RedirectToAction("Index");
		}
		public IActionResult CreateProduct()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
		{
			var newValue = _mapper.Map<Product>(createProductDto);
			await _productService.TCreateAsync(newValue);
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> UpdateProduct(int id)
		{
			var values = await _productService.TGetByIdAsync(id);
			var updateValue = _mapper.Map<UpdateProductDto>(values);
			return View(updateValue);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
		{
			var updateValue = _mapper.Map<Product>(updateProductDto);
			await _productService.TUpdateAsync(updateValue);
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> ProductDetails(int id)
		{
			var value = await _productService.TGetByIdAsync(id);
			var product = _mapper.Map<ResultProductDto>(value);
			return View(product);
		}
	}
}
