using MyOwnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyOwnProject.Entities.Concrete
{
    public class Experience : IEntity
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Title { get; set; }
        public string SubtitleAndDate { get; set; }
        public string Description { get; set; }
    }
}
