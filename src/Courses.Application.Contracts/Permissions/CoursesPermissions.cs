namespace Courses.Permissions;

public static class CoursesPermissions
{
    public const string GroupCourses = "Courses";
    public const string GroupLessons = "Lessons";
    public const string GroupTags = "Tags";


    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class Courses
    {
        public const string Default = GroupCourses + ".Courses";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class Lessons
    {
        public const string Default = GroupLessons + ".Lessons";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class Tags
    {
        public const string Default = GroupTags + ".Tags";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}

