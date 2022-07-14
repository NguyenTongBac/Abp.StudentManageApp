using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentManage.Web;

[Dependency(ReplaceServices = true)]
public class StudentManageBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StudentManage";
}
