using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Acme.StudentManage.Models.Lop;

namespace Acme.StudentManage.Services
{
    public interface ILopAppService : ICrudAppService<
        LopResponse,
        Guid,
        PagedAndSortedResultRequestDto,
        LopRequest,
        LopRequest>
    {

    }
}
