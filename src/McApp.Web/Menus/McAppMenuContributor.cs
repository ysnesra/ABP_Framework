using System.Threading.Tasks;
using McApp.Localization;
using McApp.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace McApp.Web.Menus;

public class McAppMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<McAppResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                McAppMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        //testtt
        context.Menu.AddItem(
            new ApplicationMenuItem("McAppMenus.Appointment", l["Menu:Appointment"],url: "/appointment",icon: "fas fa-calendar",order:1)
                .AddItem(new ApplicationMenuItem(
                    name: "McAppMenus.AppointmentNew",
                    displayName: l["Menu:AppointmentNew"],
                    url: "/appointment/new")
                ).AddItem(new ApplicationMenuItem(
                    name: "McAppMenus.Appointments",
                    displayName: l["Menu:Appointments"],
                    url: "/appointment/list")
                ).AddItem(new ApplicationMenuItem(
                    name: "McAppMenus.AppointmentCalendar",
                    displayName: l["Menu:AppointmentCalendar"],
                    url: "/appointment/calendar")
                )
        );


        context.Menu.AddItem(
           new ApplicationMenuItem("McAppMenus.OurServices", l["Menu:OurServices"], 
           url: "/OurService",
           icon: "fas fa-list", order: 3)
               
       );





        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}
