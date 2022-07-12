using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using Acme.StudentManage.Models.SinhVien;
using Volo.Abp.Application.Dtos;

namespace Acme.StudentManage.Services
{
    public interface ISinhVienAppService :
    ICrudAppService<
    SinhVienResponse, Guid, PagedAndSortedResultRequestDto, SinhVienRequest, SinhVienRequest>
    {
    }
}
