using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Svg File", 
        GUID = "2fd3691b-64d9-4cdf-86b7-c9f8938cca27", 
        Description = "Use this to upload Scalable Vector Graphic (SVG) images.")]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class SvgFile : MediaData
    {
        // instead of generating a smaller bitmap file for thumbnail,
        // // use the same binary vector image for thumbnail
        public override Blob Thumbnail => base.BinaryData;

        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Description",
            Description = "Description field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Description { get; set; }

    }
}