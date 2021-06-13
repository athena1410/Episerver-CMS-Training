using System.Web.Mvc;

namespace AlloyTraining.Views.CustomViewEngine
{
    public class EpiserverViewEngine : RazorViewEngine
    {
        public static readonly string[] PartialViewLocations = 
        {
            "~/Views/Blocks/{1}.cshtml",
            "~/Views/Shared/{0}.cshtml",

            "~/Views/Blocks/{1}/{0}.cshtml",
            "~/Views/Shared/{1}/{0}.cshtml"
        };
        
        public static readonly string[] ViewLocations = {
            "~/Views/Pages/{1}.cshtml",
            "~/Views/Nodes/{1}.cshtml",
            "~/Views/Catalog/{1}.cshtml",

            "~/Views/Pages/{1}/{0}.cshtml",
            "~/Views/Nodes/{1}/{0}.cshtml",
            "~/Views/Catalog/{1}/{0}.cshtml"
        };

        public EpiserverViewEngine()
        {
            PartialViewLocationFormats = EpiserverViewEngine.PartialViewLocations;
            ViewLocationFormats = EpiserverViewEngine.ViewLocations;
        }
    }
}