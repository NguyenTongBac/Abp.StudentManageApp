using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;
using Acme.StudentManage.Services;
using Acme.StudentManage.Models.SinhVien;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Acme.StudentManage.Web.Pages.Commons.SinhVien
{
    public class EditModalModel : StudentManagePageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public SinhVienRequest sinhVien { get; set; }

        private readonly ISinhVienAppService _service;

        public EditModalModel(ISinhVienAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var respone = await _service.GetAsync(Id);
            sinhVien = ObjectMapper.Map<SinhVienResponse, SinhVienRequest>(respone);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, sinhVien);
            return NoContent();
        }
    }
}
