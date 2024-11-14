using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Courses.Lessons;

public interface ILessonAppService :
    ICrudAppService<
        LessonDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateLessonDto>
{

}