using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentManage.Data;

/* This is used if database provider does't define
 * IStudentManageDbSchemaMigrator implementation.
 */
public class NullStudentManageDbSchemaMigrator : IStudentManageDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
