using Volo.Abp.Modularity;

namespace Courses;

public abstract class CoursesApplicationTestBase<TStartupModule> : CoursesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
