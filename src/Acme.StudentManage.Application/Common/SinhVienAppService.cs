using Acme.StudentManage.Entities.Common;
using Acme.StudentManage.Models.SinhVien;
using Acme.StudentManage.Permissions;
using Acme.StudentManage.Repositories;
using Acme.StudentManage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentManage.Common
{
    public class SinhVienAppService : CrudAppService<SinhVien, SinhVienResponse, Guid, PagedAndSortedResultRequestDto,
        SinhVienRequest, SinhVienRequest>, ISinhVienAppService
    {
        private readonly ISinhVienRepository _repository;
        public SinhVienAppService(ISinhVienRepository sinhVien,IRepository<SinhVien, Guid> repository) : base(repository)
        {
            _repository = sinhVien;
            GetPolicyName = StudentManagePermissions.SinhVien.Default;
            GetListPolicyName = StudentManagePermissions.SinhVien.Default;
            CreatePolicyName = StudentManagePermissions.SinhVien.Create;
            UpdatePolicyName = StudentManagePermissions.SinhVien.Update;
            DeletePolicyName = StudentManagePermissions.SinhVien.Delete;
        }
        public async override Task<PagedResultDto<SinhVienResponse>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            PagedResultDto<SinhVien> item = await _repository.GetListAsync(input);
            List<SinhVienResponse> result = new List<SinhVienResponse>();
            foreach (var itemDto in item.Items)
            {
                var sinhVienResponse = ObjectMapper.Map<SinhVien, SinhVienResponse>(itemDto);
                sinhVienResponse.Lop = itemDto.Lop == null ? "" : itemDto.Lop.name;
                result.Add(sinhVienResponse);
            }
            return new PagedResultDto<SinhVienResponse>(item.TotalCount, result);
        }
    }
}
