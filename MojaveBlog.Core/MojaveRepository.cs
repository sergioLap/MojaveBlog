using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using NHibernate.Transform;

namespace MojaveBlog.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class MojaveRepository: IRepository
    {
        // NHibernate object
        private readonly ISession _session;

        public MojaveRepository(ISession session)
        {
            _session = session;
        }
        
        public IList<Post> Posts(int pageNo, int PageSize)
        {
            var posts = _session.Query<Post>()
                                .Where(p=>p.Published)
                                .OrderByDescending(p=>p.DatePost)
                                .Skip(pageNo* PageSize)
                                .Take(PageSize)
                                .Fetch(p=>p.Category)
                                .ToList();
            var postIds = posts.Select(p => p.PostId).ToList();


            return _session.Query<Post>()
                            .Where(p => postIds.Contains(p.PostId))
                            .OrderByDescending(p => p.DatePost)
                            .Fetch(p => p.Tags)
                            .ToList();
             
        }

        public int TotalPosts() => _session.Query<Post>().Count(p => p.Published);
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Post> PostsForCategory(string categorySlug, int pageNo, int pageSize)
        {
            var posts = _session.Query<Post>()
                                .Where(p=>p.Published && p.Category.UrlSlug.Equals(categorySlug))
                                .OrderByDescending(p=>p.DatePost)
                                .Skip(pageNo * pageSize)
                                .Take(pageSize)
                                .Fetch(p=>p.Category)
                                .ToList();

            var postIds = posts.Select(p => p.PostId).ToList();

            return _session.Query<Post>()
                           .Where(p=>postIds.Contains(p.PostId))
                           .OrderByDescending(p=>p.DatePost)
                           .FetchMany(p=>p.Tags)
                           .ToList();
        }

        public int TotalPostsForCategory(string categorySlug)
        {
          return  _session.Query<Post>()
                    .Where(p=>p.Published && p.Category.UrlSlug == categorySlug)
                    .Count();
        }

        public Category Category(string categorySlug)
        {
            return _session.Query<Category>()
                           .FirstOrDefault(p => p.UrlSlug.Equals(categorySlug));
        }

        public IList<Post> PostsForTag(string tagSlug, int pageNo, int pageSize)
        {
           var posts = _session.Query<Post>()
                                .Where(p=>p.Published && p.Tags.Any(t=>t.UrlSlug.Equals(tagSlug)))
                                .OrderByDescending(p=>p.DatePost)
                                .Skip(pageNo * pageSize)
                                .Take(pageSize)
                                .Fetch(p=>p.Category)
                                .ToList();

            var postIds = posts.Select(p => p.PostId).ToList();


            return _session.Query<Post>()
                           .Where(p=>postIds.Contains(p.PostId))
                           .OrderByDescending(p=>p.DatePost)
                           .FetchMany(p => p.Tags)
                           .ToList();

        }

        public int TotalPostsForTag(string tagSlug)
        {
            return _session.Query<Post>().Count(p => p.Tags.Any(t => t.UrlSlug.Equals(tagSlug)));
        }

        public Tag Tag(string tagSlug)
        {
            return _session.Query<Tag>().FirstOrDefault(t => t.UrlSlug.Equals(tagSlug));
        }
    }
}
