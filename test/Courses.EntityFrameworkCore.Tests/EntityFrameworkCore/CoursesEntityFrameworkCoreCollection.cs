using Xunit;

namespace Courses.EntityFrameworkCore;

[CollectionDefinition(CoursesTestConsts.CollectionDefinitionName)]
public class CoursesEntityFrameworkCoreCollection : ICollectionFixture<CoursesEntityFrameworkCoreFixture>
{

}
