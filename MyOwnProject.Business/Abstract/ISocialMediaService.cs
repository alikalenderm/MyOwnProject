using MyOwnProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOwnProject.Business.Abstract
{
    public interface ISocialMediaService
    {
        List<SocialMedia> Getlist();
        void Add(SocialMedia socialMedia);
        void Update(SocialMedia socialMedia);
        SocialMedia GetById(int id);
        void Delete(int id);
    }
}
