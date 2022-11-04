using Microsoft.AspNetCore.Mvc;
using MyOwnProject.Business.Abstract;
using MyOwnProject.Entities.Concrete;
using MyOwnProject.WebUI.Areas.Admin.Models.SocialMediaModel;

namespace MyOwnProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediasController : Controller
    {
        private ISocialMediaService _socialMediaService;
       

        public SocialMediasController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IActionResult Index()
        {
            var model = new SocialMediaListViewModel()
            {
                socialMedias = _socialMediaService.Getlist()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new SocialMediaAddViewModel()
            {
                SocialMedia = new SocialMedia()
            };

            return View(model);
        }
        public IActionResult Add(SocialMedia socialMedia)
        {
            _socialMediaService.Add(socialMedia);
            return RedirectToAction("Index", "SocialMedias");
        }

        public IActionResult Delete(int id)
        {
            var socialMediaModel = _socialMediaService.GetById(id);
            _socialMediaService.Delete(socialMediaModel.SocialMediaId);
            return RedirectToAction("Index", "Services");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var socialMediaGetByIdModel = _socialMediaService.GetById(id);
            if (socialMediaGetByIdModel!=null)
            {
                var model = new SocialMediaUpdateViewModel()
                {
                    SocialMedia = new SocialMedia
                    {
                        SocialMediaId = socialMediaGetByIdModel.SocialMediaId,
                        SocialMediaName = socialMediaGetByIdModel.SocialMediaName,
                        Address = socialMediaGetByIdModel.Address,
                        Icon = socialMediaGetByIdModel.Icon
                    }
                };
                return View(model);
            }
            return View();
            
        }
        public IActionResult Update(SocialMedia socialMedia)
        {
            _socialMediaService.Update(socialMedia);
            return RedirectToAction("Index", "SocialMedias", new { Area = "Admin" });
        }


    }
}
