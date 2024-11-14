using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Courses.Tags;

public class Tag : AuditedAggregateRoot<Guid>
{
    public required string TagName { get; set; }

    public List<int>? CoursesId { get; set; }

    public List<int>? LessonsId { get; set; }
}
