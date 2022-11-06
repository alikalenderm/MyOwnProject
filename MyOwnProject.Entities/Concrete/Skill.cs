using MyOwnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyOwnProject.Entities.Concrete
{
    public class Skill : IEntity
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillItem { get; set; }
        public int SkillItemPercent { get; set; }
    }
}
