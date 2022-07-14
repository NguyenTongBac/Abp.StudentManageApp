using Microsoft.AspNetCore.Mvc;
using Acme.StudentManage.Models.Lop;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Acme.StudentManage.Services;

namespace Acme.StudentManage.Web.Pages.Commons.Lop
{
    public class CreateModalModel : StudentManagePageModel
    {
        [BindProperty]
        public LopRequest ViewModel { get; set; }
        private readonly ILopAppService _service;

        public CreateModalModel(ILopAppService service)
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
