using Microsoft.AspNetCore.Mvc;
using MyOwnProject.Business.Abstract;
using MyOwnProject.Entities.Concrete;
using MyOwnProject.WebUI.Areas.Admin.Models.ContactModel;

namespace MyOwnProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactsController : Controller
    {
        private IContactService _contactService;
        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var model = new ContactListViewModel()
            {
                Contacts = _contactService.Getlist()
            };

            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var model = new ContactAddViewModel()
            {
                Contact = new Contact()
            };
            return View(model);
        }

        public IActionResult Add(Contact contact)
        {
            _contactService.Add(contact);
            return RedirectToAction("Index", "Contacts");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contactModel = _contactService.GetById(id);
            _contactService.Delete(contactModel.ContactId);
            return RedirectToAction("Index", "Contacts");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var contactGetByIdModel = _contactService.GetById(id);
            if (contactGetByIdModel!=null)
            {
                var model = new ContactUpdateViewModel()
                {
                    Contact = new Contact
                    {
                        ContactId = contactGetByIdModel.ContactId,
                        Title = contactGetByIdModel.Title,
                        Subtitle = contactGetByIdModel.Subtitle
                    }
                };
                return View(model);
            }
            return View();
        }
        public IActionResult Update(Contact contact)
        {
            _contactService.Update(contact);
            return RedirectToAction("Index", "Contacts", new { Area = "Admin" });
        }
    }
}
