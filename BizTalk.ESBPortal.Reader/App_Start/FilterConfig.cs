﻿using System.Web;
using System.Web.Mvc;

namespace BizTalk.ESBPortal.Reader
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
