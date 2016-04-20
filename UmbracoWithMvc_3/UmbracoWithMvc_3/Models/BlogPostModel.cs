using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace UmbracoWithMvc_3.Models
{
    public class BlogPostModel
    {
        private IPublishedContent content;
        private UmbracoHelper umbraco;

        public BlogPostModel(IPublishedContent content, UmbracoHelper umbraco)
        {
            this.content = content;
            this.umbraco = umbraco;
        }

        public DateTime CreateDate
        {
            get { return content.CreateDate; }
        }

        public string Url
        {
            get { return content.Url; }
        }

        public string name
        {
            get { return content.Name; }
        }

        public IHtmlString Introduction
        {
            get
            {
                var value = (string)content.GetProperty("Introduction").Value;
                return umbraco.Truncate(value, 240, true);
            }
        }
    }
}