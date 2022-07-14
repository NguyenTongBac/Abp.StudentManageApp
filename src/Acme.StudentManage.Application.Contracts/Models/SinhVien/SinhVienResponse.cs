using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.StudentManage.Models.SinhVien
{
    public class SinhVienResponse : EntityDto<Guid>
    {
        public string name { get; set; }
        public int CMND { get; set; }
        public int age { get; set; }
        public string Lop { get; set; }
    }
}
