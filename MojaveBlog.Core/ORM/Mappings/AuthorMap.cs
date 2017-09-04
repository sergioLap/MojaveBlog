using FluentNHibernate.Mapping;

namespace MojaveBlog.Core.Mappings
{
    public class AuthorMap : ClassMap<Author>
    {
        /// <summary>
        /// 
        /// </summary>
        public AuthorMap()
        {
            Table("author");

            Id(x => x.AuthorId).Column("authorid");

            Map(x => x.Name).Column("name").Length(50).Not.Nullable();

            Map(x => x.UrlSlug).Column("urlslug").Length(200).Not.Nullable();

            Map(x => x.Description).Column("description").Length(5000);

            HasManyToMany(x => x.Posts).Cascade.All().Inverse().Table("post_author");
        }
    }
}