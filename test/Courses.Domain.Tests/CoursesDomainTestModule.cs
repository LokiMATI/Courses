using Volo.Abp.Modularity;

namespace Courses;

[DependsOn(
    typeof(CoursesDomainModule),
    typeof(CoursesTestBaseModule)
)]
public class CoursesDomainTestModule : AbpModule
{

}
