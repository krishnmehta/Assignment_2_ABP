using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace StudentAssignment.Pages;

public class Index_Tests : StudentAssignmentWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
