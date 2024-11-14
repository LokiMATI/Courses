using Courses.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Courses.Tags;

public class TagAppService :
    CrudAppService<
        Tag,
        TagDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateTagDto>,
    ITagAppService
{
    public TagAppService(IRepository<Tag, Guid> repository)
        : base(repository)
    {
        GetPolicyName = CoursesPermissions.Tags.Default;
        GetListPolicyName = CoursesPermissions.Tags.Default;
        CreatePolicyName = CoursesPermissions.Tags.Create;
        UpdatePolicyName = CoursesPermissions.Tags.Edit;
        DeletePolicyName = CoursesPermissions.Tags.Delete;
    }
}