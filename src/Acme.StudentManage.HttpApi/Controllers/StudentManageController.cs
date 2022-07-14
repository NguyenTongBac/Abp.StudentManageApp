using Acme.StudentManage.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.StudentManage.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentManageController : AbpControllerBase
{
    protected StudentManageController()
    {
        LocalizationResource = typeof(StudentManageResource);
    }
}
