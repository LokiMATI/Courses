using Courses.Courses;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Courses.Lessons;

public class Lesson : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public Course Course { get; set; }

    public string? Material { get; set; }
}
