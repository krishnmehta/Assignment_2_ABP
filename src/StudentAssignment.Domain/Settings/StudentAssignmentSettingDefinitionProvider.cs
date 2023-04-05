using Volo.Abp.Settings;

namespace StudentAssignment.Settings;

public class StudentAssignmentSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StudentAssignmentSettings.MySetting1));
    }
}
