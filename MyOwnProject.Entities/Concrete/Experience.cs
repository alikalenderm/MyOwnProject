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
        public string Subtitle { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}
