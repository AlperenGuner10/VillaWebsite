using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Business.Validators;
using Villa.DTO.Dtos.QuestDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
	public class QuestionController : Controller
	{
		private readonly IQuestService _questService;
		private readonly IMapper _mapper;

		public QuestionController(IQuestService questService, IMapper mapper)
		{
			_questService=questService;
			_mapper=mapper;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _questService.TGetListAsync();
			var valueList = _mapper.Map<List<ResultQuestDto>>(values);
			return View(valueList);
		}
		public async Task<IActionResult> DeleteQuestion(int id)
		{
			await _questService.TDeleteAsync(id);
			return RedirectToAction("Index");
		}
		public IActionResult CreateQuestion()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateQuestion(CreateQuestDto createQuestDto)
		{
			ModelState.Clear();//Validate kısmında boş geçilemez yazısını göstermek için kullandık.
			var newValue = _mapper.Map<Quest>(createQuestDto);
			var validator = new QuestionValidator();
			var result = validator.Validate(newValue);
			if (!result.IsValid)
			{
				result.Errors.ForEach(x =>
				{
					ModelState.AddModelError(x.PropertyName,x.ErrorMessage);
				});
				return View();
			}
			await _questService.TCreateAsync(newValue);
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> UpdateQuestion(int id)
		{
			var values = await _questService.TGetByIdAsync(id);
			var updateValue = _mapper.Map<UpdateQuestDto>(values);
			return View(updateValue);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateQuestion(UpdateQuestDto updateQuestDto)
		{
			var updateValue = _mapper.Map<Quest>(updateQuestDto);
			await _questService.TUpdateAsync(updateValue);
			return RedirectToAction("Index");
		}
	}
}
