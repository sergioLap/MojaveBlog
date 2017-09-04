//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NHibernate.Mapping.ByCode;
//using NHibernate.Mapping.ByCode.Conformist;

//namespace MojaveBlog.Core.Mappings
//{
//    public class PostMapping: ClassMapping<Post>
//    {
//        public PostMapping()
//        {
//            Table("post");
//            Id(x=>x.PostId, m =>
//            {
//                m.Generator(Generators.Native);
//                m.Column("postid");

//            });

//            Property(x => x.Title, m =>
//            {
//                m.Length(500);
//                m.NotNullable(true);
//                m.Column("title");
//            });
//            Property(x => x.ShortDescription, m =>
//            {
//                m.Length(5000);
//                m.NotNullable(true);
//                m.Column("shortdescription");

//            });
//            Property(x => x.Description, m =>
//            {
//                m.Length(5000);
//                m.NotNullable(true);
//                m.Column("description");

//            });
//            Property(x => x.Meta, m =>
//            {
//                m.Length(1000);
//                m.NotNullable(true);
//                m.Column("meta");

//            });
//            Property(x => x.UrlSlug, m =>
//            {
//                m.Length(200);
//                m.NotNullable(true);
//                m.Column("urlslug");

//            });
//            Property(x => x.Published, m =>
//            {
//                m.NotNullable(true);
//                m.Column("published");

//            });
//            Property(x => x.DatePost, m =>
//            {
//                m.NotNullable(true);
//                m.Column("datepost");

//            });

//            Property(x => x.DateModified, act => act.Column("datemodified"));

//            ManyToOne(post => post.Category, act =>
//            {
//                act.Cascade(Cascade.Persist);
//                act.NotNullable(true);
//                act.Column("categoryid");

//            });

//            Set(post => post.Authors, act =>
//            {
//                act.Cascade(Cascade.Persist);
//                act.Key(k => k.Column("postid"));
//                act.Table("post_author");
//            }, r=>r.ManyToMany(m=>m.Column("authorid")));

//            Set(post => post.Tags, act =>
//            {
//                act.Cascade(Cascade.Persist);
//                act.Key(k => k.Column("postid"));
//                act.Table("post_tag");
//            }, r => r.ManyToMany(m => m.Column("tagid")));



//        }
//    }
//}
