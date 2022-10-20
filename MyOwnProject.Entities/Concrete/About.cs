using MyOwnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyOwnProject.Entities.Concrete
{
    public class About:IEntity
    {
        [Key]
        public int AboutId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string FirstEmail { get; set; }
        public string SecondEmail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string SoftwareArea { get; set; }
    }
}
