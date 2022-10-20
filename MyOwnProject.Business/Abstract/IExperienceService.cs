using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Abstract
{
    public interface IExperienceService
    {
        List<Experience> Getlist();
        void Add(Experience experience);
        void Update(Experience experience);
        Experience GetById(int id);
        void Delete(int id);
    }
}
