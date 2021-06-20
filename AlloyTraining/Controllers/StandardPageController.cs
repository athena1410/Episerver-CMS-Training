using AlloyTraining.Models.Pages;
using EPiServer;
using System.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class StandardPageController : PageControllerBase<StandardPage>
    {
        public StandardPageController(IContentLoader contentLoader) : base(contentLoader)
        {
        }

        public ActionResult Index(StandardPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(CreatePageViewModel(currentPage));
        }
    }
}