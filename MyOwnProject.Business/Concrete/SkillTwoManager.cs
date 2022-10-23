using MyOwnProject.Business.Abstract;
using MyOwnProject.DataAccess.Abstract;
using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Concrete
{
    public  class SkillTwoManager : ISkillTwoService
    {
        private ISkillTwoDal _skillTwoDal;
        public SkillTwoManager(ISkillTwoDal SkillTwoDal)
        {
            _skillTwoDal = SkillTwoDal;
        }

        public void Add(SkillTwo SkillTwo)
        {
            _skillTwoDal.Add(SkillTwo);
        }

        public void Delete(int id)
        {
            _skillTwoDal.Delete(GetById(id));
        }

        public SkillTwo GetById(int id)
        {
            return _skillTwoDal.Get(a => a.SkillId == id);
        }

        public List<SkillTwo> Getlist()
        {
            return _skillTwoDal.GetAll();
        }

        public void Update(SkillTwo SkillTwo)
        {
            _skillTwoDal.Update(SkillTwo);
        }
    }
}
