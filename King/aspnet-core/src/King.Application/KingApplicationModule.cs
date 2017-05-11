using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using King.Authorization;

namespace King
{
    [DependsOn(
        typeof(KingCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class KingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<KingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KingApplicationModule).GetAssembly());
        }
    }
}