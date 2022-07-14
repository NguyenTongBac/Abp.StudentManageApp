using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.StudentManage.Pages;

public class Index_Tests : StudentManageWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
