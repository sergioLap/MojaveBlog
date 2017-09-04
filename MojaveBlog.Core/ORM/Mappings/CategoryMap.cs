using FluentNHibernate.Mapping;

namespace MojaveBlog.Core.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table("category");

            Id(x => x.CategoryId).Column("categoryid");

            Map(x => x.Name).Column("name").Length(50).Not.Nullable();

            Map(x => x.UrlSlug).Column("urlslug").Length(50).Not.Nullable();

            Map(x => x.Description).Column("description").Length(200);

            HasMany(x => x.Posts).Inverse().Cascade.All().KeyColumn("category");
        }
    }
}