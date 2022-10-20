using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Abstract
{
    public interface IAboutService
    {
        List<About> Getlist();
        void Add(About about);
        void Update(About about);
        About GetById(int id);
        void Delete(int id);
    }
}
