using Acme.StudentManage.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.StudentManage.Permissions;

public class StudentManagePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StudentManagePermissions.GroupName);
        var myGroupCommon = context.AddGroup(StudentManagePermissions.GroupNameCommon, L("Permission:Common"));

        var lopPermission = myGroupCommon.AddPermission(StudentManagePermissions.Lop.Default, L("Permission:Lop"));
        lopPermission.AddChild(StudentManagePermissions.Lop.Create, L("Permission:Create"));
        lopPermission.AddChild(StudentManagePermissions.Lop.Update, L("Permission:Update"));
        lopPermission.AddChild(StudentManagePermissions.Lop.Delete, L("Permission:Delete"));

        var sinhVienPermission = myGroupCommon.AddPermission(StudentManagePermissions.SinhVien.Default, L("Permission:SinhVien"));
        sinhVienPermission.AddChild(StudentManagePermissions.SinhVien.Create, L("Permission:Create"));
        sinhVienPermission.AddChild(StudentManagePermissions.SinhVien.Update, L("Permission:Update"));
        sinhVienPermission.AddChild(StudentManagePermissions.SinhVien.Delete, L("Permission:Delete"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(StudentManagePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentManageResource>(name);
    }
}
