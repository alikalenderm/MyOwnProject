using MyOwnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyOwnProject.Entities.Concrete
{
    public class Contact : IEntity
    {
        [Key]
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
    }
}
