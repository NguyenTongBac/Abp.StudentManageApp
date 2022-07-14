using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.StudentManage.Models.Lop
{
    public class LopRequest
    {
        [Required(ErrorMessage = "Requied")]
        [StringLength(255)]
        [Display(Name = "LopName", Prompt = "PlaceHolder")]
        public string name { get; set; }

        [Required(ErrorMessage = "Requied")]
        [StringLength(1000)]
        [Display(Name = "ghichu", Prompt = "PlaceHolder")]
        public string note { get; set; }
    }
}
