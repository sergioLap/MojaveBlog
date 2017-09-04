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
        public ListViewModel(IRepository _mojaveRepository, int p)
        {
            Posts = _mojaveRepository.Posts(p - 1, 10);
            TotalPosts = !Posts.Any() ? 0 : _mojaveRepository.TotalPosts();
        }

        public IList<Post> Posts { get; set; }
        public int TotalPosts { get; set; }
    }
}
