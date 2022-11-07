using System.Reflection;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Zero;
using Abp.Zero.Configuration;
using AbpGleapTest.Authorization;
using AbpGleapTest.Authorization.Roles;
using AbpGleapTest.Authorization.Users;
using AbpGleapTest.Configuration;
using AbpGleapTest.MultiTenancy;

namespace AbpGleapTest
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class AbpGleapTestCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            //Remove the following line to disable multi-tenancy.
            Configuration.MultiTenancy.IsEnabled = AbpGleapTestConsts.MultiTenancyEnabled;

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    AbpGleapTestConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        Assembly.GetExecutingAssembly(),
                        "AbpGleapTest.Localization.Source"
                        )
                    )
                );

            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Authorization.Providers.Add<AbpGleapTestAuthorizationProvider>();

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = AbpGleapTestConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
