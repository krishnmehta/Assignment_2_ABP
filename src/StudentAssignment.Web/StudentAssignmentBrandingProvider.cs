using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace StudentAssignment.Web;

[Dependency(ReplaceServices = true)]
public class StudentAssignmentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StudentAssignment";
}
