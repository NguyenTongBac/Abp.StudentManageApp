using Acme.StudentManage.Entities.Common;
using Acme.StudentManage.Models.SinhVien;
using Acme.StudentManage.Permissions;
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
        public SinhVienAppService(IRepository<SinhVien, Guid> repository) : base(repository)
        {
            GetPolicyName = StudentManagePermissions.SinhVien.Default;
            GetListPolicyName = StudentManagePermissions.SinhVien.Default;
            CreatePolicyName = StudentManagePermissions.SinhVien.Create;
            UpdatePolicyName = StudentManagePermissions.SinhVien.Update;
            DeletePolicyName = StudentManagePermissions.SinhVien.Delete;
        }
    }
}
