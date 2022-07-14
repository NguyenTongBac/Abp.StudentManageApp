using Volo.Abp.Modularity;

namespace Acme.StudentManage;

[DependsOn(
    typeof(StudentManageApplicationModule),
    typeof(StudentManageDomainTestModule)
    )]
public class StudentManageApplicationTestModule : AbpModule
{

}
