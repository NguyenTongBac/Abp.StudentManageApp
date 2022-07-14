using Acme.StudentManage.Entities.Common;
using Acme.StudentManage.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.StudentManage.Repositories
{
    public class SinhVienRepository : EfCoreRepository<StudentManageDbContext, SinhVien, Guid>, ISinhVienRepository
    {
        public SinhVienRepository(IDbContextProvider<StudentManageDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public async Task<PagedResultDto<SinhVien>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            PagedResultDto<SinhVien> list = new PagedResultDto<SinhVien>();
            list.TotalCount = await GetQueryable().Where(w => !w.IsDeleted).CountAsync();
            list.Items = await GetQueryable().Where(w => !w.IsDeleted).Include(t => t.Lop).OrderByDescending(w => w.CreationTime).Skip(input.SkipCount).Take(input.MaxResultCount).AsNoTracking().ToListAsync();
            return list;
        }
    }
}
