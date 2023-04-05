using StudentAssignment.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace StudentAssignment.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class StudentAssignmentPageModel : AbpPageModel
{
    protected StudentAssignmentPageModel()
    {
        LocalizationResourceType = typeof(StudentAssignmentResource);
    }
}
