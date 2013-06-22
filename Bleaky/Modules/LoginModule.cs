using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace Bleaky.Modules
{
    public class LoginModule : NancyModule
    {
        public LoginModule() : base("/Login")
        {
            Get["/"] = Index;
            Post["/"] = Login;
        }

        dynamic Index(dynamic parameters)
        {
            return View["Index.cshtml"];
        }

        dynamic Login(dynamic parameters)
        {
            var x = 1;
            return Response.AsRedirect("/");
        }
    }
}