using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Acme.StudentManage.Web.Pages.Commons.SinhVien
{
    public class IndexModel : PageModel
    {
        public virtual async void OngetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
