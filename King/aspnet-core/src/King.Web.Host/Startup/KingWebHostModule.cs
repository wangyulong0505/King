using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using King.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace King.Web.Host.Startup
{
    [DependsOn(
       typeof(KingWebCoreModule))]
    public class KingWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public KingWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KingWebHostModule).GetAssembly());
        }
    }
}
