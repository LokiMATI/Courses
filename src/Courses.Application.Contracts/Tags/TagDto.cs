using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Courses.Tags;

public class TagDto : AuditedEntityDto<Guid>
{
    public string TagName { get; set; }

    public List<Guid>? LessonsId { get; set; }
}
