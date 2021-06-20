using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(
        DisplayName = "Standard", 
        GroupName = SiteGroupNames.COMMON,
        GUID = "c8e8dc2d-4255-4d36-97d3-a6fb04ba45bc", 
        Description = "Use this page type unless you need a more specialized one.")]
    [SitePageIcon]
    [AvailableContentTypes(Include = new []{typeof(StandardPage)},
        Exclude = new []{typeof(ProductPage)})]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }

    }
}