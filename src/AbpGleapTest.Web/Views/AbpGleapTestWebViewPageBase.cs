using Abp.Web.Mvc.Views;

namespace AbpGleapTest.Web.Views
{
    public abstract class AbpGleapTestWebViewPageBase : AbpGleapTestWebViewPageBase<dynamic>
    {

    }

    public abstract class AbpGleapTestWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AbpGleapTestWebViewPageBase()
        {
            LocalizationSourceName = AbpGleapTestConsts.LocalizationSourceName;
        }
    }
}