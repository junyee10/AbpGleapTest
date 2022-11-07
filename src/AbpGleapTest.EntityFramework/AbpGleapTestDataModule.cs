using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using AbpGleapTest.EntityFramework;

namespace AbpGleapTest
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AbpGleapTestCoreModule))]
    public class AbpGleapTestDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AbpGleapTestDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
