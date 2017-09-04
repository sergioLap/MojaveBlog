using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaveBlog.Core
{
    /// <summary>
    /// Пост.
    /// </summary>
    public class Post
    {
        public virtual int PostId
        { get; set; }

        public virtual string Title
        { get; set; }

        public virtual string ShortDescription
        { get; set; }

        public virtual string Description
        { get; set; }

        /// <summary>
        /// Метаданные описания поста.
        /// </summary>
        public virtual string Meta
        { get; set; }

        /// <summary>
        /// Описание тэга для строки запроса.
        /// </summary>
        public virtual string UrlSlug
        { get; set; }

        /// <summary>
        /// метка опубиликован.
        /// </summary>
        public virtual bool Published
        { get; set; }

        /// <summary>
        /// Авторы поста.
        /// </summary>
        public virtual IList<Author> Authors
        { get; set; }

        public virtual DateTime DatePost
        { get; set; }

        public virtual DateTime? DateModified
        { get; set; }

        /// <summary>
        /// Категория поста.
        /// </summary>
        public virtual Category Category
        { get; set; }

        /// <summary>
        /// Список тэгов.
        /// </summary>
        public virtual IList<Tag> Tags
        { get; set; }
    }
}
