using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.StudentManage.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentManage.EntityFrameworkCore;

public class EntityFrameworkCoreStudentManageDbSchemaMigrator
    : IStudentManageDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStudentManageDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the StudentManageDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StudentManageDbContext>()
            .Database
            .MigrateAsync();
    }
}
