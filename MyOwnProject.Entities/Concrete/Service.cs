using MyOwnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyOwnProject.Entities.Concrete
{
    public class Service : IEntity
    {
        [Key]
        public int ServiceId { get; set; }
        public string SoftwareArea { get; set; }
        public string Address { get; set; }
    }
}
