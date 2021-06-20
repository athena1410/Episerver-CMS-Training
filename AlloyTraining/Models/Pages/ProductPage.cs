using AlloyTraining.Business.SelectionFactories;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;

namespace AlloyTraining.Models.Pages
{
    [ContentType(
        DisplayName = "Product",
        GroupName = SiteGroupNames.SPECIALIZED,
        Order = 20,
        GUID = "0c8a0fa6-ec39-4f99-8a85-6b7dadaeee78",
        Description = "")]
    [SiteCommerceIcon]
    public class ProductPage : SitePageData
    {
        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        [Display(Name = "Color theme",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual string Theme { get; set; }

        [CultureSpecific]
        [Display(Name = "Unique Selling Points",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [Required]
        public virtual IList<string> UniqueSellingPoints { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            Theme = "OrangeTheme";
        }
    }
}