using Nancy;
using Nancy.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyFx_MyTemplate
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            this.Conventions.StaticContentsConventions.Add(Nancy.Conventions.StaticContentConventionBuilder.AddDirectory("assets"));
        }
    }
}