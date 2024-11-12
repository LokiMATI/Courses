using Courses.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Courses.Lessons;

public class LessonAppService :
    CrudAppService<
        Lesson,
        LessonDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateLessonDto>,
    ILessonAppService
{
    public LessonAppService(IRepository<Lesson, Guid> repository)
        : base(repository)
    {
        GetPolicyName = CoursesPermissions.Lessons.Default;
        GetListPolicyName = CoursesPermissions.Lessons.Default;
        CreatePolicyName = CoursesPermissions.Lessons.Create;
        UpdatePolicyName = CoursesPermissions.Lessons.Edit;
        DeletePolicyName = CoursesPermissions.Lessons.Delete;
    }
}