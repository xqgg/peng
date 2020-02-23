using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.TagHelpers
{
    [HtmlTargetElement("pager", Attributes = "path,PageIndex")]
    public class PagerTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            output.TagName = "a";
            object pageIndex = context.AllAttributes["pageIndex"].Value;
            object path = context.AllAttributes["path"].Value;
            output.Attributes.Add("href", $"{path}/page-{pageIndex}");
            output.Attributes.Remove(context.AllAttributes["path"]);
            output.Attributes.Remove(context.AllAttributes["pageIndex"]);
        }
    }
}
