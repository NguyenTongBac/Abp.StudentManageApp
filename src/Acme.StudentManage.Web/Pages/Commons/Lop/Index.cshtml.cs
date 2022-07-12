using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Acme.StudentManage.Web.Pages.Commons.Lop
{
    public class IndexModel : PageModel
    {
        public virtual async void OngetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
