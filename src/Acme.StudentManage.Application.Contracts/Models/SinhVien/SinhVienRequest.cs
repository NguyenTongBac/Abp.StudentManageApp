using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.StudentManage.Models.SinhVien
{
    public class SinhVienRequest
    {
        [Required(ErrorMessage = "Requried")]
        [StringLength(255)]
        [Display(Name = "SinhVienName", Prompt = "PlaceHolder")]

        public string name { get; set; }

        [Required(ErrorMessage = "Requried")]
        [Display(Name = "SinhVienAge", Prompt = "PlaceHolder")]

        public int age { get; set; }

        [Required(ErrorMessage = "Requried")]
        [StringLength(20)]
        [Display(Name = "CMND", Prompt = "PlaceHolder")]
        public string CMND { get; set; }

        [Required(ErrorMessage = "Requried")]
        public virtual Guid lopId { get; set; }
    }
}
