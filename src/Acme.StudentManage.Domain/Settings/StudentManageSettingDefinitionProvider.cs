using Volo.Abp.Settings;

namespace Acme.StudentManage.Settings;

public class StudentManageSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StudentManageSettings.MySetting1));
    }
}
