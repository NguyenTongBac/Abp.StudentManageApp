using Acme.StudentManage.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.StudentManage.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentManageEntityFrameworkCoreModule),
    typeof(StudentManageApplicationContractsModule)
    )]
public class StudentManageDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
