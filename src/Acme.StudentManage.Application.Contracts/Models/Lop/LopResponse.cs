using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.StudentManage.Models.Lop
{
    public class LopResponse: EntityDto<Guid>
    {
        public string name { get; set; }
        public string note { get; set; }
    }
}
