using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace StudentAssignment.Data;

/* This is used if database provider does't define
 * IStudentAssignmentDbSchemaMigrator implementation.
 */
public class NullStudentAssignmentDbSchemaMigrator : IStudentAssignmentDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
