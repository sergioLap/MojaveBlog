using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MojaveBlog.Core;

namespace MojaveBlog.Models
{
    public class WidgetViewModel
    {
        public IList<Post> Posts { get; set; }
        public WidgetViewModel(IRepository blogRepository)
        {
            Categories = blogRepository.Categories();
        }

        public IList<Category> Categories { get; private set; }


    }
}
