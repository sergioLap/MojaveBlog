using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaveBlog.Core
{
    public class Tag
    {
        /// <summary>
        /// Идентификатор тэга.
        /// </summary>
        public virtual int TagId { get; set; }

        /// <summary>
        /// Название тэга.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Описание тэга.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Описание тэга для строки запроса.
        /// </summary>
        public virtual string UrlSlug { get; set; }

        /// <summary>
        /// Список постов с тэгом.
        /// </summary>
        public virtual IList<Post> Posts { get; set; }




    }
}
