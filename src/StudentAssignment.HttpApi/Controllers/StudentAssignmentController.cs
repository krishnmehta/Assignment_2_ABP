using StudentAssignment.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StudentAssignment.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentAssignmentController : AbpControllerBase
{
    protected StudentAssignmentController()
    {
        LocalizationResource = typeof(StudentAssignmentResource);
    }
}
