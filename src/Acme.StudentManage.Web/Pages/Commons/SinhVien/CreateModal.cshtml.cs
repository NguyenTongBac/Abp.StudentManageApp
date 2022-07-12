using Acme.StudentManage.Models.SinhVien;
using Acme.StudentManage.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Acme.StudentManage.Web.Pages.Commons.SinhVien
{
    public class CreateModalModel : StudentManagePageModel
    {
        [BindProperty]
        public SinhVienRequest ViewModel { get; set; }
        private readonly ISinhVienAppService _service;

        public CreateModalModel(ISinhVienAppService service)
        {
            _service = service;
        }
        public void OnGet()
        {

        }
        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(ViewModel);
            return NoContent();
        }
    }
}
