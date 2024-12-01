using AutoMapper;
using Courses.Courses;
using Courses.Lessons;
using Courses.Tags;

namespace Courses;

public class CoursesApplicationAutoMapperProfile : Profile
{
    public CoursesApplicationAutoMapperProfile()
    {
        CreateMap<Course, CourseDto>();
        CreateMap<CreateUpdateCourseDto, Course>();

        CreateMap<Lesson, LessonDto>();
        CreateMap<CreateUpdateLessonDto, Lesson>();

        CreateMap<Tag, TagDto>();
        CreateMap<CreateUpdateTagDto, Tag>();
    }
}
