using Courses.Courses;
using Courses.Tags;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Courses.Lessons;

public class Lesson : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public Guid CourseId { get; set; }

    public List<Tag>? Tags { get; set; }

    public string? Material { get; set; }
}
