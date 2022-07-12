namespace Acme.StudentManage.Permissions;

public static class StudentManagePermissions
{
    public const string GroupName = "StudentManage";
    public const string GroupNameCommon = "Common";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public class Lop
    {
        public const string Default = GroupNameCommon + ".Lop";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
    public class SinhVien
    {
        public const string Default = GroupNameCommon + ".SinhVien";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
