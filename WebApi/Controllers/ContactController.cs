using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
	[EnableCors]
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}
		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			List<ContactModel> list = new List<ContactModel>();
			foreach (Contact item in _contactService.TGetAll())
			{
				ContactModel model = new ContactModel();
				model.ContactId = item.ContactId;
				model.FirstName = item.FirstName;
				model.LastName = item.LastName;
				model.Email = item.Email;
				model.PhoneNumber= item.PhoneNumber;
				model.Subject= item.Subject;
				model.Message= item.Message;
				model.CreatedAt = item.CreatedAt;
				model.ContactStatus = item.ContactStatus;
				list.Add(model);
			}
			return Ok(list);
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var value=_contactService.TGetById(id);
			return Ok(value);
		}
		[HttpPost("add")]
		public IActionResult Add(ContactModel contactModel)
		{
			Contact contact = new Contact();
			contact.ContactId = contactModel.ContactId;
			contact.FirstName = contactModel.FirstName;
			contact.LastName = contactModel.LastName;
			contact.Email = contactModel.Email;
			contact.PhoneNumber = contactModel.PhoneNumber;
			contact.Subject = contactModel.Subject;
			contact.Message = contactModel.Message;
			contact.CreatedAt = contactModel.CreatedAt;
			contact.ContactStatus = contactModel.ContactStatus;
			_contactService.TAdd(contact);
			return Ok(contact);
		}
		[HttpPut("update")]
		public IActionResult Update(ContactModel contactModel)
		{
			Contact contact = new Contact();
			contact.ContactId = contactModel.ContactId;
			contact.FirstName = contactModel.FirstName;
			contact.LastName = contactModel.LastName;
			contact.Email = contactModel.Email;
			contact.PhoneNumber = contactModel.PhoneNumber;
			contact.Subject = contactModel.Subject;
			contact.Message = contactModel.Message;
			contact.CreatedAt = contactModel.CreatedAt;
			contact.ContactStatus = contactModel.ContactStatus;
			_contactService.TUpdate(contact);
			return Ok(contact);
		}
		[HttpDelete("delete")]
		public IActionResult Delete(ContactModel contactModel)
		{
			Contact contact = new Contact();
			contact.ContactId = contactModel.ContactId;
			contact.FirstName = contactModel.FirstName;
			contact.LastName = contactModel.LastName;
			contact.Email = contactModel.Email;
			contact.PhoneNumber = contactModel.PhoneNumber;
			contact.Subject = contactModel.Subject;
			contact.Message = contactModel.Message;
			contact.CreatedAt = contactModel.CreatedAt;
			contact.ContactStatus = contactModel.ContactStatus;
			_contactService.TDelete(contact);
			return Ok(contact);
		}
	}

}
