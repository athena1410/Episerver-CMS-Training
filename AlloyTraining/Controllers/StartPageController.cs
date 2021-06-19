using AlloyTraining.Models.Pages;
using System.Web.Mvc;
using EPiServer;

namespace AlloyTraining.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public StartPageController(IContentLoader contentLoader) : base(contentLoader)
        {
            
        }

        public ActionResult Index(StartPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(CreatePageViewModel(currentPage));
        }
    }
}