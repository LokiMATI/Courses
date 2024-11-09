using Courses.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Courses.Web.Pages;

public abstract class CoursesPageModel : AbpPageModel
{
    protected CoursesPageModel()
    {
        LocalizationResourceType = typeof(CoursesResource);
    }
}
