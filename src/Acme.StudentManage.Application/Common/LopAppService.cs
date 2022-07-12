using Acme.StudentManage.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Acme.StudentManage.Models.Lop;
using Acme.StudentManage.Services;

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
        }
    }
}
