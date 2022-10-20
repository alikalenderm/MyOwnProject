using MyOwnProject.Business.Abstract;
using MyOwnProject.DataAccess.Abstract;
using MyOwnProject.DataAccess.Concrete;
using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public void Delete(int id)
        {
            _contactDal.Delete(GetById(id));
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(c => c.ContactId == id);
        }

        public List<Contact> Getlist()
        {
            return _contactDal.GetAll();
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
