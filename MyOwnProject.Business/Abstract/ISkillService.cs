using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Abstract
{
    public interface ISkillService
    {
        List<Skill> Getlist();
        void Add(Skill skill);
        void Update(Skill skill);
        Skill GetById(int id);
        void Delete(int id);
    }
}
