using Courses.Permissions;
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
        GetPolicyName = CoursesPermissions.Courses.Default;
        GetListPolicyName = CoursesPermissions.Courses.Default;
        CreatePolicyName = CoursesPermissions.Courses.Create;
        UpdatePolicyName = CoursesPermissions.Courses.Edit;
        DeletePolicyName = CoursesPermissions.Courses.Delete;
    }
}