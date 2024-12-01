using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Courses.Tags;

public class Tag : AuditedAggregateRoot<Guid>
{
    public string TagName { get; set; }

    public List<Guid>? LessonsId { get; set; }
}
