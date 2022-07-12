using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.StudentManage.Entities.Common
{
    public class SinhVien: FullAuditedAggregateRoot<Guid>
    {
        public string name { get; set; }
        public int CMND { get; set; }
        public int age { get; set; }
        public Guid lopID { get; set; }
        public Lop Lop { get; set; }
    }
}
