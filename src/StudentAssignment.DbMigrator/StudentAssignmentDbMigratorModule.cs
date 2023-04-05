using StudentAssignment.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace StudentAssignment.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentAssignmentEntityFrameworkCoreModule),
    typeof(StudentAssignmentApplicationContractsModule)
    )]
public class StudentAssignmentDbMigratorModule : AbpModule
{

}
