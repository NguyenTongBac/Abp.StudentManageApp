using Acme.StudentManage.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.StudentManage.Permissions;

public class StudentManagePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StudentManagePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StudentManagePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentManageResource>(name);
    }
}
