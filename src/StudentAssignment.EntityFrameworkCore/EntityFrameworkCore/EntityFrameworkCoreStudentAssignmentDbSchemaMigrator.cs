using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentAssignment.Data;
using Volo.Abp.DependencyInjection;

namespace StudentAssignment.EntityFrameworkCore;

public class EntityFrameworkCoreStudentAssignmentDbSchemaMigrator
    : IStudentAssignmentDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStudentAssignmentDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the StudentAssignmentDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StudentAssignmentDbContext>()
            .Database
            .MigrateAsync();
    }
}
