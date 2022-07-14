using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Acme.StudentManage.Models.Lop;
using System.Threading.Tasks;
using Acme.StudentManage.Models.Search;

namespace Acme.StudentManage.Services
{
    public interface ILopAppService : ICrudAppService<
        LopResponse,
        Guid,
        PagedAndSortedResultRequestDto,
        LopRequest,
        LopRequest>
    {
        /// <summary>
        /// Tìm kiếm lớp
        /// </summary>
        /// <param name="condition">điều kiện search</param>
        /// <returns></returns>
        Task<PagedResultDto<LopResponse>> SearchAsync(ConditionSearchRequest condition);
    }
}
