using MyOwnProject.Entities.Concrete;
using System.Collections.Generic;

namespace MyOwnProject.WebUI.Areas.Admin.Models.SocialMediaModel
{
    public class SocialMediaListViewModel
    {
        public List<SocialMedia> socialMedias { get; set; }
        public SocialMedia SocialMedia { get; set; }
    }
}
