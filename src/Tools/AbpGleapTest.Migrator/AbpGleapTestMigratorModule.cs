using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using AbpGleapTest.EntityFramework;

namespace AbpGleapTest.Migrator
{
    [DependsOn(typeof(AbpGleapTestDataModule))]
    public class AbpGleapTestMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AbpGleapTestDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}