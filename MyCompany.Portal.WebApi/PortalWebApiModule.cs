﻿using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace MyCompany.Portal
{
    [DependsOn(typeof(AbpWebApiModule), typeof(PortalApplicationModule))]
    public class PortalWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(PortalApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
