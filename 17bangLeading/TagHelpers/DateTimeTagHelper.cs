using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.TagHelpers
{
    [HtmlTargetElement("datetime", Attributes = "asp-showicon,asp-only")]
    public class DateTimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            output.TagName = "small";
            object showicon = context.AllAttributes["asp-showicon"].Value;
            object only = context.AllAttributes["asp-only"].Value;
            if (Convert.ToBoolean(showicon.ToString()))
            {
                output.PreContent.SetHtmlContent("<span class='glyphicon glyphicon-calendar'></span>");
            }
            if (only.ToString().Equals("date"))
            {
                string strDateTime = output.GetChildContentAsync().Result.GetContent();
                output.Content.Append(Convert.ToDateTime(strDateTime).ToLongDateString());
            }
        }
    }
}
