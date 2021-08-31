using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using AddressBook.Authorization.Roles;
using AddressBook.Authorization.Users;
using AddressBook.Configuration;
using AddressBook.Localization;
using AddressBook.MultiTenancy;
using AddressBook.Timing;

namespace AddressBook
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class AddressBookCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            AddressBookLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = AddressBookConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = AddressBookConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AddressBookCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
