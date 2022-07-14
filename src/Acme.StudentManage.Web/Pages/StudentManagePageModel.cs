using Acme.StudentManage.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.StudentManage.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class StudentManagePageModel : AbpPageModel
{
    protected StudentManagePageModel()
    {
        LocalizationResourceType = typeof(StudentManageResource);
    }
}
