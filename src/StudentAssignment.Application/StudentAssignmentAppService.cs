using System;
using System.Collections.Generic;
using System.Text;
using StudentAssignment.Localization;
using Volo.Abp.Application.Services;

namespace StudentAssignment;

/* Inherit your application services from this class.
 */
public abstract class StudentAssignmentAppService : ApplicationService
{
    protected StudentAssignmentAppService()
    {
        LocalizationResource = typeof(StudentAssignmentResource);
    }
}
