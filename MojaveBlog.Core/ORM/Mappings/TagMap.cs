using FluentNHibernate.Mapping;
using MojaveBlog.Core;

namespace MojaveBlog.Core.Mappings
{
    /// <summary>
    /// 
    /// </summary>
    public class TagMap : ClassMap<Tag>
    {
        /// <summary>
        /// 
        /// </summary>
        public TagMap()
        {
            Table("tag");

            Id(x => x.TagId).Column("tagid");

            Map(x => x.Name).Column("name").Length(50).Not.Nullable();

            Map(x => x.UrlSlug).Column("urlslug").Length(50).Not.Nullable();

            Map(x => x.Description).Column("description").Length(200);
            
            HasManyToMany(x => x.Posts).Cascade.All().Inverse().Table("post_tag");
        }
    }
}