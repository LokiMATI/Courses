using Courses.Localization;
using Volo.Abp.Application.Services;

namespace Courses;

/* Inherit your application services from this class.
 */
public abstract class CoursesAppService : ApplicationService
{
    protected CoursesAppService()
    {
        LocalizationResource = typeof(CoursesResource);
    }
}
