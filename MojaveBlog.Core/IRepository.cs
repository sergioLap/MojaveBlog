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

    }
}
