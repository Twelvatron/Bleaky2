using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;


namespace Bleaky.Modules
{
    public class ExercisesModule : NancyModule
    {
        public ExercisesModule() : base("/Exercises")
        {
            Before += ctx =>
            {
                return (this.Context.CurrentUser == null) ? Response.AsRedirect("/login") : null;
            };

            Get["/"] = Index;
        }

        dynamic Index(dynamic parameters)
        {
            return View["Index.cshtml"];
        }
    }
}