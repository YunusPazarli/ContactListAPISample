using Contact.API.Models.ORM.Context;
using Contact.API.Models.ORM.Entities;
using Contact.API.Models.ORM.VM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.API.Controllers
{
    [ApiController]
    public class ContactsController : Controller
    {
        private readonly ContactsContext _contactsContext;

        public ContactsController(ContactsContext contactsContext)
        {
            _contactsContext = contactsContext;
        }

        [Route("contactlist")]
        [HttpGet]
        public List<ContactListVM> GetContactLists()
        {
            var contacts = _contactsContext.ContactLists.Where(q => q.IsDeleted == false).Select(q => new ContactListVM()
            {
                ID = q.ID,
                Name = q.Name,
                Surname = q.Surname,
                Phone = q.Phone,
                //Address = q.Addresses
            }).ToList();

            return contacts;
        }

        [Route("contacts/add")]
        [HttpPost]
        public IActionResult AddContact([FromForm] AddContactVM model)
        {
            if (ModelState.IsValid)
            {
                Contacts contact = new Contacts();
                contact.Name = model.Name;
                contact.Surname = model.Surname;
                contact.Company = model.Company;

                _contactsContext.Contacts.Add(contact);
                _contactsContext.SaveChanges();

                model.ID = contact.ID;

                return Ok(model);
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }

        [Route("contacts/delete")]
        [HttpPost]
        public IActionResult DeleteContact([FromForm] DeleteContactVM model)
        {
            var contacts = _contactsContext.Contacts.Find(model.ID);

            if (contacts != null)
            {
                contacts.IsDeleted = true;
                _contactsContext.SaveChanges();

                
                return Ok(contacts);
            }
            else
            {
                return BadRequest("There is nothing here.");
            }
        }
    }
}
