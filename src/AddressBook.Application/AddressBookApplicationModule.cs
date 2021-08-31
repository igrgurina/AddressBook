using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AddressBook.Authorization;

namespace AddressBook
{
    [DependsOn(
        typeof(AddressBookCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AddressBookApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AddressBookAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AddressBookApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
