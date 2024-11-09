using Courses.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Courses.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CoursesEntityFrameworkCoreModule),
    typeof(CoursesApplicationContractsModule)
)]
public class CoursesDbMigratorModule : AbpModule
{
}
