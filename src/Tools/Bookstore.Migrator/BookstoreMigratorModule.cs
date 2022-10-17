using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Bookstore.EntityFramework;

namespace Bookstore.Migrator
{
    [DependsOn(typeof(BookstoreDataModule))]
    public class BookstoreMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<BookstoreDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}