using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.StudentManage.Entities.Common
{
    public class Lop : FullAuditedAggregateRoot<Guid>
    {
        public string name { get; set; }
        public string note { get; set; }
        public List<SinhVien> SinhViens { get; set; }
    }
}
