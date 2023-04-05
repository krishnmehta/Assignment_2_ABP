using Volo.Abp.Modularity;

namespace StudentAssignment;

[DependsOn(
    typeof(StudentAssignmentApplicationModule),
    typeof(StudentAssignmentDomainTestModule)
    )]
public class StudentAssignmentApplicationTestModule : AbpModule
{

}
