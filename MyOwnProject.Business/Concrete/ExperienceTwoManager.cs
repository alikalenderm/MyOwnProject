using MyOwnProject.Business.Abstract;
using MyOwnProject.DataAccess.Abstract;
using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Concrete
{
    public class ExperienceTwoManager : IExperienceTwoService
    {
        IExperienceTwoDal _experienceTwoDal;
        public ExperienceTwoManager(IExperienceTwoDal experienceTwoDal)
        {
            _experienceTwoDal = experienceTwoDal;
        }

        public void Add(ExperienceTwo experienceTwo)
        {
            _experienceTwoDal.Add(experienceTwo);
        }

        public void Delete(int id)
        {
            _experienceTwoDal.Delete(GetById(id));
        }

        public ExperienceTwo GetById(int id)
        {
            return _experienceTwoDal.Get(e => e.ExperienceId == id);
        }

        public List<ExperienceTwo> Getlist()
        {
            return _experienceTwoDal.GetAll();
        }

        public void Update(ExperienceTwo experienceTwo)
        {
            _experienceTwoDal.Update(experienceTwo);
        }
    }
}
