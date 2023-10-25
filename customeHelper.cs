using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace WebApplication5
{
    public static class CustomHtmlHelpers
    {

        public static MvcHtmlString CustomButton(this HtmlHelper htmlHelper, string buttonText, string cssClass)
        {
            var buttonTag = new TagBuilder("button");
            buttonTag.InnerHtml = buttonText;
            buttonTag.AddCssClass(cssClass);
            return new MvcHtmlString(buttonTag.ToString());
        }
    }
}