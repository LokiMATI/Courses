using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Courses.Courses;

public class CourseAppService :
    CrudAppService<
        Course,
        CourseDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCourseDto>,
    ICourseAppService
{
    public CourseAppService(IRepository<Course, Guid> repository)
        : base(repository)
    {

    }
}