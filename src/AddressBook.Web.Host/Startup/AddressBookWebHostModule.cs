using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AddressBook.Configuration;

namespace AddressBook.Web.Host.Startup
{
    [DependsOn(
       typeof(AddressBookWebCoreModule))]
    public class AddressBookWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AddressBookWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AddressBookWebHostModule).GetAssembly());
        }
    }
}
