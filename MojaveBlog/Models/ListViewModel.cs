using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MojaveBlog.Core;

namespace MojaveBlog.Models
{
    public class ListViewModel
    {
        public IList<Post> Posts { get; set; }
        public int TotalPosts { get; set; }

        public Category Category { get; private set; }
        public Tag Tag { get; private set; }
        public string Search { get; private set; }

        public ListViewModel(IRepository _mojaveRepository, int p)
        {
            Posts = _mojaveRepository.Posts(p - 1, 10);
            TotalPosts = !Posts.Any() ? 0 : _mojaveRepository.TotalPosts();
        }

        public ListViewModel(IRepository blogRepository, string text, string type, int p)
        {

            switch (type)
            {
                case "Category":
                    Posts = blogRepository.PostsForCategory(text, p - 1, 10);
                    TotalPosts = blogRepository.TotalPostsForCategory(text);
                    Category = blogRepository.Category(text);
                    break;
                case "Tag":
                    Posts = blogRepository.PostsForTag(text, p - 1, 10);
                    TotalPosts = blogRepository.TotalPostsForTag(text);
                    Tag = blogRepository.Tag(text);
                    break;
                default:
                    Posts = blogRepository.PostsForSearch(text, p - 1, 10);
                    TotalPosts = blogRepository.TotalPostsForSearch(text);
                    Search = text;
                    break;
            }
        }


    }
}
