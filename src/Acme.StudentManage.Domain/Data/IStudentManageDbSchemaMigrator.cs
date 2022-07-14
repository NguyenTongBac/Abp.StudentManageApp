using System.Threading.Tasks;

namespace Acme.StudentManage.Data;

public interface IStudentManageDbSchemaMigrator
{
    Task MigrateAsync();
}
