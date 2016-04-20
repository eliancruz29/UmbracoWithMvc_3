using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using UmbracoWithMvc_3.Models;

namespace UmbracoWithMvc_3.Controllers
{
    public class BlogPostRepositoryController : RenderMvcController
    {
        public ActionResult BlogOverview(RenderModel model)
        {
            ViewBag.Hello = "Hello World";

            var blogOverviewModel = new BlogOverviewModel(model.Content, Umbraco);

            return Index(new RenderModel(blogOverviewModel));
        }
    }
}