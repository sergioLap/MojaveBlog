using FluentNHibernate.Mapping;
using MojaveBlog.Core;

namespace MojaveBlog.Core.Mappings
{
    /// <summary>
    /// 
    /// </summary>
    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Table("post");
            Id(x => x.PostId).Column("postid");

            Map(x => x.Title).Column("title").Length(500).Not.Nullable();

            Map(x => x.ShortDescription).Column("shortdescription").Length(5000).Not.Nullable();

            Map(x => x.Description).Column("description").Length(5000).Not.Nullable();

            Map(x => x.Meta).Column("meta").Length(1000).Not.Nullable();

            Map(x => x.UrlSlug).Column("urlslug").Length(200).Not.Nullable();

            Map(x => x.Published).Column("published").Not.Nullable();

            Map(x => x.DatePost).Column("datepost").Not.Nullable();

            Map(x => x.DateModified).Column("datemodified");

            References(x => x.Category).Column("categoryid").Not.Nullable();

            HasManyToMany(x => x.Tags).Table("post_tag");
            HasManyToMany(x => x.Authors).Table("post_author");

        }
    }
}