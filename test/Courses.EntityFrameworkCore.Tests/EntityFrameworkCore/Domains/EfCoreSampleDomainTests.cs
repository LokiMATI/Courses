using Courses.Samples;
using Xunit;

namespace Courses.EntityFrameworkCore.Domains;

[Collection(CoursesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CoursesEntityFrameworkCoreTestModule>
{

}
