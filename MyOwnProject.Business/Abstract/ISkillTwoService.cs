using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Abstract
{
    public interface ISkillTwoService
    {
        List<SkillTwo> Getlist();
        void Add(SkillTwo SkillTwo);
        void Update(SkillTwo SkillTwo);
        SkillTwo GetById(int id);
        void Delete(int id);
    }
}
