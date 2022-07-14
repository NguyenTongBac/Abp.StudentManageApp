using Acme.StudentManage.Entities.Common;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Acme.StudentManage.Models.Lop;
using Acme.StudentManage.Services;
using Acme.StudentManage.Permissions;
using Acme.StudentManage.Models.Search;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Acme.StudentManage.Common
{
    public class LopAppService : CrudAppService<
        Lop,
        LopResponse,
        Guid,
        PagedAndSortedResultRequestDto,
        LopRequest,
        LopRequest>, ILopAppService
    {
        public LopAppService(IRepository<Lop, Guid> repository) : base(repository)
        {
            GetPolicyName = StudentManagePermissions.Lop.Default;
            GetListPolicyName = StudentManagePermissions.Lop.Default;
            CreatePolicyName = StudentManagePermissions.Lop.Create;
            UpdatePolicyName = StudentManagePermissions.Lop.Update;
            DeletePolicyName = StudentManagePermissions.Lop.Delete;
        }

        private readonly ILopAppService _service;
        /*public LopAppService(IRepository<Lop, Guid> respository) : base(respository)
        {
           
        }*/

        [HttpGet, Route("api/lop/search")]
        public async Task<PagedResultDto<LopResponse>> SearchAsync(ConditionSearchRequest condition)
        {
            var input = new PagedAndSortedResultRequestDto { MaxResultCount = 1000, SkipCount = 0 };
            if (condition.keyword == null)
            {
                condition.keyword = "";
            }
            PagedResultDto<LopResponse> listResultDto = new PagedResultDto<LopResponse>();
            var list = await this.GetListAsync(input);
            var resultSearch = list.Items.Where(x => x.name.Contains(condition.keyword));
            listResultDto.TotalCount = resultSearch.Count();
            listResultDto.Items = resultSearch.Skip(condition.SkipCount).Take(condition.MaxResultCount).ToList();
            return listResultDto;
        }
    }
}
