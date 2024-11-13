using Courses.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Courses.Permissions;

public class CoursesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        // Courses Permission
        var coursesGroup = context.AddGroup(CoursesPermissions.GroupCourses, L("Permission:Courses"));
        var coursesPermission = coursesGroup.AddPermission(CoursesPermissions.Courses.Default, L("Permission:Courses.Courses"));
        coursesPermission.AddChild(CoursesPermissions.Courses.Create, L("Permission:Courses.Create"));
        coursesPermission.AddChild(CoursesPermissions.Courses.Edit, L("Permission:Courses.Edit"));
        coursesPermission.AddChild(CoursesPermissions.Courses.Delete, L("Permission:Courses.Delete"));

        // Lessons Permission
        var lessonsGroup = context.AddGroup(CoursesPermissions.GroupLessons, L("Permission:Lessons"));
        var lessonsPermission = lessonsGroup.AddPermission(CoursesPermissions.Lessons.Default, L("Permission:Lessons.Lessons"));
        lessonsPermission.AddChild(CoursesPermissions.Lessons.Create, L("Permission:Lessons.Create"));
        lessonsPermission.AddChild(CoursesPermissions.Lessons.Edit, L("Permission:Lessons.Edit"));
        lessonsPermission.AddChild(CoursesPermissions.Lessons.Delete, L("Permission:Lessons.Delete"));

        // Tags Permission
        var tagsGroup = context.AddGroup(CoursesPermissions.GroupTags, L("Permission:Tags"));
        var tagsPermission = tagsGroup.AddPermission(CoursesPermissions.Tags.Default, L("Permission:Tags.Tags"));
        tagsPermission.AddChild(CoursesPermissions.Tags.Create, L("Permission:Tags.Create"));
        tagsPermission.AddChild(CoursesPermissions.Tags.Edit, L("Permission:Tags.Edit"));
        tagsPermission.AddChild(CoursesPermissions.Tags.Delete, L("Permission:Tags.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CoursesResource>(name);
    }
}
