using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.DTO.Dtos.ContactDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
	public class ContactController : Controller
	{
		private readonly IContactService _contactService;
		private readonly IMapper _mapper;

		public ContactController(IMapper mapper, IContactService contactService)
		{
			_mapper=mapper;
			_contactService=contactService;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _contactService.TGetListAsync();
			var contactList = _mapper.Map<List<ResultContactDto>>(values);
			return View(contactList);
		}
		public async Task<IActionResult> DeleteContact(int id)
		{
			await _contactService.TDeleteAsync(id);
			return RedirectToAction("Index");
		}
		public IActionResult CreateContact()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
		{
			var newContact = _mapper.Map<Contact>(createContactDto);
			await _contactService.TCreateAsync(newContact);
			return RedirectToAction("Index");
		}
		public async Task<IActionResult> UpdateContact(int id)
		{
			var values = await _contactService.TGetByIdAsync(id);
			var contact = _mapper.Map<UpdateContactDto>(values);
			return View(contact);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
		{
			var contact = _mapper.Map<Contact>(updateContactDto);
			await _contactService.TUpdateAsync(contact);
			return RedirectToAction("Index");
		}
	}
}
