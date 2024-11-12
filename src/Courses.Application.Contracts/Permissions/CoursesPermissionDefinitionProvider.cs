using Courses.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Courses.Permissions;

public class CoursesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var coursesGroup = context.AddGroup(CoursesPermissions.GroupName, L("Permission:Courses"));

        var coursesPermission = coursesGroup.AddPermission(CoursesPermissions.Courses.Default, L("Permission:Courses"));
        coursesPermission.AddChild(CoursesPermissions.Courses.Create, L("Permission:Courses.Create"));
        coursesPermission.AddChild(CoursesPermissions.Courses.Edit, L("Permission:Courses.Edit"));
        coursesPermission.AddChild(CoursesPermissions.Courses.Delete, L("Permission:Courses.Delete"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(CoursesPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CoursesResource>(name);
    }
}
