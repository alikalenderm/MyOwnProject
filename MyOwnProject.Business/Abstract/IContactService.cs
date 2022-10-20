using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Abstract
{
    public interface IContactService
    {
        List<Contact> Getlist();
        void Add(Contact contact);
        void Update(Contact contact);
        Contact GetById(int id);
        void Delete(int id);
    }
}
