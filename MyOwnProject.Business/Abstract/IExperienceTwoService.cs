using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Abstract
{
    public interface IExperienceTwoService
    {
        List<ExperienceTwo> Getlist();
        void Add(ExperienceTwo experienceTwo);
        void Update(ExperienceTwo experienceTwo);
        ExperienceTwo GetById(int id);
        void Delete(int id);
    }
}
