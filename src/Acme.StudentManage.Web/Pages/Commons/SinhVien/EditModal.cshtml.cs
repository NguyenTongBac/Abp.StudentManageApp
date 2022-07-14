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
    public class EditModalModel : StudentManagePageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public SinhVienModel sinhVien { get; set; }
        public List<SelectListItem> LopList { get; set; }

        private readonly ILopAppService _lopService;
        private readonly ISinhVienAppService _service;

        public EditModalModel(ISinhVienAppService service, ILopAppService lopService)
        {
            _service = service;
            _lopService = lopService;
        }

        public virtual async Task OnGetAsync()
        {
            var respone = await _service.GetAsync(Id);
            sinhVien = ObjectMapper.Map<SinhVienResponse, SinhVienModel>(respone);

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

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, sinhVien);
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
