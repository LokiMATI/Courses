using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Courses.Tags;

public class TagDto : AuditedEntityDto<Guid>
{
    public required string TagName { get; set; }

    public List<int>? CoursesId { get; set; }

    public List<int>? LessonsId { get; set; }
}
