//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NHibernate.Mapping.ByCode;
//using NHibernate.Mapping.ByCode.Conformist;

//namespace MojaveBlog.Core.Mappings
//{
//    public class AuthorMapping : ClassMapping<Author>
//    {
//        public AuthorMapping()
//        {
//            Table("author");
//            Id(x => x.AuthorId, m =>
//            {
//                m.Generator(Generators.Native);
//                m.Column("authorid");

//            });

//            Property(x => x.Name, m =>
//            {
//                m.Length(50);
//                m.NotNullable(true);
//                m.Column("name");

//            });
//            Property(x => x.Description, m =>
//            {
//                m.Length(5000);
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
//                act.Key(k => k.Column("authorid"));
//                act.Table("post_author");
//                act.Inverse(true);
//            }, r => r.ManyToMany(m => m.Column("postid")));


//        }
//    }
//}
