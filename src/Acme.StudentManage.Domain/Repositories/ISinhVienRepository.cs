using Acme.StudentManage.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentManage.Repositories
{
    public interface ISinhVienRepository : IRepository<SinhVien, Guid>
    {
        Task<PagedResultDto<SinhVien>> GetListAsync(PagedAndSortedResultRequestDto input);
    }
}
