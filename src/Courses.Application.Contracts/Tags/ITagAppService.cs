using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Courses.Tags;

public interface ITagAppService :
    ICrudAppService< 
        TagDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateTagDto>
{

}