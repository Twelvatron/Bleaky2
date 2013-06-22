using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace Bleaky.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = Index;
        }

        dynamic Index(dynamic parameters)
        {
            return View["/Index.cshtml"];
        }
    }
}