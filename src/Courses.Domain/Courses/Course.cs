using Courses.Lessons;
using System;
using System.Collections;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Courses.Courses;

public class Course: AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public string? Author { get; set; }
}
