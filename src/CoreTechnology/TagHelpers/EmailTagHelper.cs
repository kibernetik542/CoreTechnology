using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoreTechnology.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Address { get; set; }
        public string Content { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("hred","mailto:" + Address);
            output.Content.SetContent(Content);



            //base.Process(context, output);
        }
    }
}
