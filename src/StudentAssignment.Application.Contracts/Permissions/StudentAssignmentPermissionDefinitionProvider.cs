using StudentAssignment.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace StudentAssignment.Permissions;

public class StudentAssignmentPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StudentAssignmentPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StudentAssignmentPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentAssignmentResource>(name);
    }
}
