using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.DTO.Dtos.CounterDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
	public class CounterController : Controller
	{
		private readonly ICounterService _counterService;
		private readonly IMapper _mapper;

		public CounterController(ICounterService counterService, IMapper mapper)
		{
			_counterService=counterService;
			_mapper=mapper;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _counterService.TGetListAsync();
			var counterList = _mapper.Map<List<ResultCounterDto>>(values);
			return View(counterList);
		}
		public async Task<IActionResult> DeleteCounter(int id)
		{
			await _counterService.TDeleteAsync(id);
			return RedirectToAction("Index");
		}
		public IActionResult CreateCounter()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateCounter(CreateCounterDto createCounterDto)
		{
			var newCounter = _mapper.Map<Counter>(createCounterDto);
			await _counterService.TCreateAsync(newCounter);
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> UpdateCounter(int id)
		{
			var values = await _counterService.TGetByIdAsync(id);
			var counter = _mapper.Map<UpdateCounterDto>(values);
			return View(counter);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateCounter(UpdateCounterDto updateCounterDto)
		{
			var counter = _mapper.Map<Counter>(updateCounterDto);
			await _counterService.TUpdateAsync(counter);
			return RedirectToAction("Index");
		}
	}
}
