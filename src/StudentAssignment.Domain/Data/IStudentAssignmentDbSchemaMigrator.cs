using System.Threading.Tasks;

namespace StudentAssignment.Data;

public interface IStudentAssignmentDbSchemaMigrator
{
    Task MigrateAsync();
}
