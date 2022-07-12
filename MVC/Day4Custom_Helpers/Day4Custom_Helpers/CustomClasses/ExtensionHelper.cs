﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4Custom_Helpers.CustomClasses
{
    public static class ExtensionHelper
    {
        public static IHtmlString LabelWithRed(this HtmlHelper helper, string content)
        {
            string htmlstr = String.Format("<Label><i><font color=Red>{0}</font></i></Label>", content);
            return new HtmlString(htmlstr);
        }
    }
}