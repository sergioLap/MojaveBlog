//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NHibernate.Mapping.ByCode;
//using NHibernate.Mapping.ByCode.Conformist;

//namespace MojaveBlog.Core.Mappings
//{
//    public class CategoryMapping : ClassMapping<Category>
//    {
//        public CategoryMapping()
//        {
//            Table("category");
//            Id(x => x.CategoryId, m =>
//            {
//                m.Generator(Generators.Native);
//                m.Column("categoryid");

//            });

//            Property(x => x.Name, m =>
//            {
//                m.Length(50);
//                m.NotNullable(true);
//                m.Column("name");

//            });
//            Property(x => x.Description, m =>
//            {
//                m.Length(300);
//                m.NotNullable(true);
//                m.Column("description");

//            });
//            Property(x => x.UrlSlug, m =>
//            {
//                m.Length(200);
//                m.NotNullable(true);
//                m.Column("urlslug");

//            });


//            Set(post => post.Posts, act =>
//            {
//                act.Cascade(Cascade.Persist);
//                act.Key(k => k.Column("categoryid"));
//                act.Table("category_post");
//                act.Inverse(true);
//            }, r => r.ManyToMany(m => m.Column("postid")));


//        }
//    }
//}
