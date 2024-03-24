using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AnnouncementAPI.Pages;

public class Index_Tests : AnnouncementAPIWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
