using Courses.Samples;
using Xunit;

namespace Courses.EntityFrameworkCore.Applications;

[Collection(CoursesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CoursesEntityFrameworkCoreTestModule>
{

}
