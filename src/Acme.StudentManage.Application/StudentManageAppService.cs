using System;
using System.Collections.Generic;
using System.Text;
using Acme.StudentManage.Localization;
using Volo.Abp.Application.Services;

namespace Acme.StudentManage;

/* Inherit your application services from this class.
 */
public abstract class StudentManageAppService : ApplicationService
{
    protected StudentManageAppService()
    {
        LocalizationResource = typeof(StudentManageResource);
    }
}
