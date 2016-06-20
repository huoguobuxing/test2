using System.Reflection;
using Abp.Modules;

namespace MyCompany.Portal
{
    [DependsOn(typeof(PortalCoreModule))]
    public class PortalApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
