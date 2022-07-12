using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;
using Acme.StudentManage.Services;
using Acme.StudentManage.Models.Lop;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.ObjectMapping;

namespace Acme.StudentManage.Web.Pages.Commons.Lop
{
    public class EditModalModel : StudentManagePageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public LopRequest Lop { get; set; }

        private readonly ILopAppService _service;

        public EditModalModel(ILopAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var respone = await _service.GetAsync(Id);
            Lop = ObjectMapper.Map<LopResponse, LopRequest>(respone);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, Lop);
            return NoContent();
        }
    }
}
