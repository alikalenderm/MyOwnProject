using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Abstract
{
    public interface IServiceService
    {
        List<Service> Getlist();
        void Add(Service service);
        void Update(Service service);
        Service GetById(int id);
        void Delete(int id);
    }
}
