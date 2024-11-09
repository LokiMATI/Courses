using Volo.Abp.Modularity;

namespace Courses;

[DependsOn(
    typeof(CoursesApplicationModule),
    typeof(CoursesDomainTestModule)
)]
public class CoursesApplicationTestModule : AbpModule
{

}
