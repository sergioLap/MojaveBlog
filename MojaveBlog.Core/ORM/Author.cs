using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaveBlog.Core
{
    public class Author
    {
        /// <summary>
        /// Идентификатор Автора.
        /// </summary>
        public virtual int AuthorId { get; set; }

        /// <summary>
        /// Имя Автора.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Об Авторе.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Описание Автора для строки запроса.
        /// </summary>
        public virtual string UrlSlug { get; set; }

        /// <summary>
        /// Список постов Автора.
        /// </summary>
        public virtual List<Post> Posts { get; set; }




    }
}
