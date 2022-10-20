using MyOwnProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyOwnProject.Entities.Concrete
{
    public class SocialMedia : IEntity
    {
        [Key]
        public int SocialMediaId { get; set; }
        public string SocialMediaName { get; set; }
    }
}
