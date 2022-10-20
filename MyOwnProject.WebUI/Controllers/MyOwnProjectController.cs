using Microsoft.AspNetCore.Mvc;
using MyOwnProject.Business.Abstract;
using MyOwnProject.WebUI.Model;

namespace MyOwnProject.WebUI.Controllers
{
    public class MyOwnProjectController : Controller
    {
        private IAboutService _aboutService;
        private IContactService _contactService;
        private IPortfolioService _portfolioService;
        private IExperienceService _experienceService;
        private IServiceService _serviceservice;
        private ISkillService _skillService;
        private ISocialMediaService _socialMediaService;

        public MyOwnProjectController(IAboutService aboutService, IContactService contactService, IPortfolioService portfolioService, IExperienceService experienceService, IServiceService serviceservice, ISkillService skillService, ISocialMediaService socialMediaService)
        {
            _aboutService = aboutService;
            _contactService = contactService;
            _portfolioService = portfolioService;
            _experienceService = experienceService;
            _serviceservice = serviceservice;
            _skillService = skillService;
            _socialMediaService = socialMediaService;
        }

        public IActionResult Index()
        {
            var model = new MyOwnProjectListViewModel
            {
                Abouts = _aboutService.Getlist(),
                Contacts = _contactService.Getlist(),
                Portfolios = _portfolioService.Getlist(),
                Experiences = _experienceService.Getlist(),
                Services = _serviceservice.Getlist(),
                Skills = _skillService.Getlist(),
                SocialMedias = _socialMediaService.Getlist()
            };
            return View(model);
        }
    }
}
