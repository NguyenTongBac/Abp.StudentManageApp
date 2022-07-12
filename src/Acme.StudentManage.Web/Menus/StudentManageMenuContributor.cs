using System.Threading.Tasks;
using Acme.StudentManage.Localization;
using Acme.StudentManage.MultiTenancy;
using Acme.StudentManage.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.StudentManage.Web.Menus;

public class StudentManageMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<StudentManageResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                StudentManageMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );
        context.Menu.AddItem(new ApplicationMenuItem("TongQuan", "Tổng quan", url: "/#", icon: "fa fa-signal", order: 1, cssClass: "tongQuan"));

        var lop = await context.IsGrantedAsync(StudentManagePermissions.Lop.Default);
        if (lop)
        {
            context.Menu.AddItem(new ApplicationMenuItem("Lop", "Lớp", icon: "fa fa-circle", order: 2, url: "/Commons/Lop"));
        }

        var sinhVien = await context.IsGrantedAsync(StudentManagePermissions.SinhVien.Default);
        if (sinhVien)
        {
            context.Menu.AddItem(new ApplicationMenuItem("SinhVien", "Sinh viên", icon: "fa fa-users", order: 3, url: "/Commons/SinhVien"));
        }

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
    }
}
