using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaveBlog.Core
{
    public class Category
    {
        public virtual int CategoryId
        { get; set; }

        /// <summary>
        /// Название категории.
        /// </summary>
        public virtual string Name
        { get; set; }

        /// <summary>
        /// Описание тэга для строки запроса.
        /// </summary>
        public virtual string UrlSlug
        { get; set; }

        public virtual string Description
        { get; set; }

        /// <summary>
        /// Список постов по категории.
        /// </summary>
        public virtual IList<Post> Posts
        { get; set; }
    }
}
