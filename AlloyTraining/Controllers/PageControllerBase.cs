using System.Linq;
using AlloyTraining.Models.Pages;
using EPiServer.Web.Mvc;
using System.Web.Mvc;
using System.Web.Security;
using AlloyTraining.Business.ExtensionMethods;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;

namespace AlloyTraining.Controllers
{
    public class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        protected readonly IContentLoader ContentLoader;

        public PageControllerBase(IContentLoader contentLoader)
        {
            ContentLoader = contentLoader;
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(TPage currentPage) where TPage : SitePageData
        {
            var viewModel = PageViewModel.Create(currentPage);

            viewModel.StartPage = ContentLoader.Get<StartPage>(ContentReference.StartPage);

            viewModel.MenuPages = FilterForVisitor.Filter(
                    ContentLoader.GetChildren<SitePageData>(ContentReference.StartPage))
                .Cast<SitePageData>().Where(page => page.VisibleInMenu);

            viewModel.Section = currentPage.ContentLink.GetSection();

            return viewModel;
        }
    }
}