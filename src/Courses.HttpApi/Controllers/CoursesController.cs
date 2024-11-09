using Courses.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Courses.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CoursesController : AbpControllerBase
{
    protected CoursesController()
    {
        LocalizationResource = typeof(CoursesResource);
    }
}
