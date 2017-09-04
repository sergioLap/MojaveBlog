using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cache;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;

namespace MojaveBlog.Core
{
    /// <summary>
    /// Группировка сопостовлений/привязок для модуля.
    /// </summary>
    public class MojaveRepositoryModule: NinjectModule
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Load()
        {
            //todo перейти на мапинг xml
            //Configuration configuration = new Configuration();

            //foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            //{
            //    if(assembly.FullName.Contains("MojaveBlog"))
            //    configuration.AddAssembly(assembly);
            //}

            //configuration.AddAssembly("MojaveBlog");
            //configuration.Configure();

            //Bind<ISessionFactory>().ToMethod(context => configuration.BuildSessionFactory()).InSingletonScope();

            //Bind<ISession>().ToMethod((ctx) => ctx.Kernel.Get<ISessionFactory>().OpenSession()).InRequestScope();

            //------------------------ версия из примера

            Bind<ISessionFactory>()
                .ToMethod
                (
                    e => 
                        Fluently.Configure()
                        .Database(PostgreSQLConfiguration.Standard.ConnectionString(c =>
                            c.FromConnectionStringWithKey("MojaveBlogDbConnString")))
                        .Cache(c => c.UseQueryCache().ProviderClass<HashtableCacheProvider>())
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Post>())

                        // .ExposeConfiguration(cfg => new SchemaExport(cfg).Execute(true, true, false))
                        .BuildConfiguration()
                        .BuildSessionFactory()
                )
                .InSingletonScope();

            Bind<ISession>()
                .ToMethod((ctx) => ctx.Kernel.Get<ISessionFactory>().OpenSession())
                .InRequestScope();


        }
    }
}
