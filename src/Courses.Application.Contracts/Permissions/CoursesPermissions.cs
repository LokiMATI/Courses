namespace Courses.Permissions;

public static class CoursesPermissions
{
    public const string GroupCourses = "Courses";
    public const string GroupLessons = "Lessons";


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
        public const string Default = GroupLessons + ".Courses";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}

