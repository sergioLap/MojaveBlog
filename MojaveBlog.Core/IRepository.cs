using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaveBlog.Core
{
    /// <summary>
    /// Шаблон Repository для доступа к БД.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Возвращает последние опубликованные посты с пагинацией.
        /// </summary>
        /// <param name="pageNo">номер страницы</param>
        /// <param name="PageSize">количество постов</param>
        /// <returns></returns>
        IList<Post> Posts(int pageNo, int PageSize);

        /// <summary>
        /// Общее количество опубликованных постов.
        /// </summary>
        /// <returns></returns>
        int TotalPosts();

        /// <summary>
        /// Посты определенной категории.
        /// </summary>
        /// <param name="categorySlug"></param>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        IList<Post> PostsForCategory(string categorySlug, int pageNo, int pageSize);
        /// <summary>
        /// Общее количество опубликованных постов по категории.
        /// </summary>
        /// <param name="categorySlug"></param>
        /// <returns></returns>
        int TotalPostsForCategory(string categorySlug);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categorySlug"></param>
        /// <returns></returns>
        Category Category(string categorySlug);

        /// <summary>
        /// Посты определенному тэгу.
        /// </summary>
        /// <returns></returns>
        IList<Post> PostsForTag(string tagSlug, int pageNo, int pageSize);
        
        /// <summary>
        /// Общее количество опубликованных постов по категории.
        /// </summary>
        int TotalPostsForTag(string tagSlug);
        
        /// <summary>
        /// 
        /// </summary>
        Tag Tag(string tagSlug);


    }
}
