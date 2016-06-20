﻿using Abp.Web.Mvc.Views;

namespace MyCompany.Portal.Web.Views
{
    public abstract class PortalWebViewPageBase : PortalWebViewPageBase<dynamic>
    {

    }

    public abstract class PortalWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected PortalWebViewPageBase()
        {
            LocalizationSourceName = PortalConsts.LocalizationSourceName;
        }
    }
}