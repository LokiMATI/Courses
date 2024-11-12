using AutoMapper;
using Courses.Courses;
using Courses.Lessons;

namespace Courses;

public class CoursesApplicationAutoMapperProfile : Profile
{
    public CoursesApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Course, CourseDto>();
        CreateMap<CreateUpdateCourseDto, Course>();
        CreateMap<Lesson, LessonDto>();
        CreateMap<CreateUpdateLessonDto, Lesson>();
    }
}
