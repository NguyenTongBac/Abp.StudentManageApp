using Acme.StudentManage.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.StudentManage;

[DependsOn(
    typeof(StudentManageEntityFrameworkCoreTestModule)
    )]
public class StudentManageDomainTestModule : AbpModule
{

}
