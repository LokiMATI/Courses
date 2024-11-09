using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Courses.Pages;

[Collection(CoursesTestConsts.CollectionDefinitionName)]
public class Index_Tests : CoursesWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
