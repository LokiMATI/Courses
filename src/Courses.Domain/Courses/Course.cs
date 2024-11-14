using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Courses.Courses;

public class Course: AuditedAggregateRoot<Guid>
{
    public required string Name { get; set; }

    public DateTime PublishDate { get; set; }

    public string? Author { get; set; }

    public List<int>? LessonsId { get; set; }
}
