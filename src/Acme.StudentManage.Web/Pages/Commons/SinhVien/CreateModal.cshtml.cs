using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;
using Acme.StudentManage.Services;
using Acme.StudentManage.Models.SinhVien;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using System.ComponentModel.DataAnnotations;

namespace Acme.StudentManage.Web.Pages.Commons.SinhVien
{
    public class CreateModalModel : StudentManagePageModel
    {
        [BindProperty]
        public SinhVienModel ViewModel { get; set; }
        public List<SelectListItem> LopList { get; set; }


        private readonly ISinhVienAppService _service;
        private readonly ILopAppService _lopService;

        public CreateModalModel(ISinhVienAppService service, ILopAppService lopService)
        {
            _service = service;
            _lopService = lopService;
        }
        public virtual async Task OnGetAsync()
        {
            var lopList = await _lopService.GetListAsync(new PagedAndSortedResultRequestDto { MaxResultCount = 1000 });
            LopList = new List<SelectListItem>();
            LopList.Add(new SelectListItem
            {
                Value = "",
                Text = "Chọn lớp",
                Selected = true
            });
            foreach (var item in lopList.Items)
            {
                LopList.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.name.ToString(),
                });
            }
        }
        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(ViewModel);
            return NoContent();
        }
        public class SinhVienModel : SinhVienRequest
        {
            [SelectItems(nameof(LopList))]
            [Display(Name = "Lop")]
            public override Guid lopId { get; set; }
        }
    }
}
