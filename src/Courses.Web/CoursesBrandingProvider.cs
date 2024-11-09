using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Courses.Localization;

namespace Courses.Web;

[Dependency(ReplaceServices = true)]
public class CoursesBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CoursesResource> _localizer;

    public CoursesBrandingProvider(IStringLocalizer<CoursesResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
