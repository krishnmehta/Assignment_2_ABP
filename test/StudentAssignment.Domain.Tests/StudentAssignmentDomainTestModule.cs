using StudentAssignment.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace StudentAssignment;

[DependsOn(
    typeof(StudentAssignmentEntityFrameworkCoreTestModule)
    )]
public class StudentAssignmentDomainTestModule : AbpModule
{

}
