using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using MojaveBlog.Core;

namespace MojaveBlog
{
    /// <summary>
    /// 
    /// </summary>
    public static class ActionLinkExtensions
    {
        public static MvcHtmlString PostLink(this HtmlHelper helper, Post post)
        {
            return helper.ActionLink(post.Title, "Post", "Mojave",
                new
                {
                    year = post.DatePost.Year,
                    month = post.DatePost.Month,
                    title = post.UrlSlug
                },
                new
                {
                    title = post.Title
                });
        }

        public static MvcHtmlString CategoryLink(this HtmlHelper helper,
            Category category)
        {
            return helper.ActionLink(category.Name, "Category", "Mojave",
                new
                {
                    category = category.UrlSlug
                },
                new
                {
                    title = String.Format("See all posts in {0}", category.Name)
                });
        }

        public static MvcHtmlString TagLink(this HtmlHelper helper, Tag tag)
        {
            return helper.ActionLink(tag.Name, "Tag", "Mojave", new { tag = tag.UrlSlug },
                new
                {
                    title = String.Format("See all posts in {0}", tag.Name)
                });
        }
    }
}