using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using AbpGleapTest.Authorization;

namespace AbpGleapTest.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class AbpGleapTestNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", AbpGleapTestConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home",
                        requiresAuthentication: true
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Tenants",
                        L("Tenants"),
                        url: "#tenants",
                        icon: "fa fa-globe",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Tenants)
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Users",
                        L("Users"),
                        url: "#users",
                        icon: "fa fa-users",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Users)
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Roles",
                        L("Roles"),
                        url: "#roles",
                        icon: "fa fa-tag",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Roles)
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", AbpGleapTestConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpGleapTestConsts.LocalizationSourceName);
        }
    }
}
