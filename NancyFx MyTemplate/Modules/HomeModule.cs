using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyFx_MyTemplate.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index"];
            };
        }
    }
}