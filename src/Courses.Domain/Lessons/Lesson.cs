using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Courses.Lessons;

public class Lesson : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public Guid? CourseId { get; set; }

    public string? Material {  get; set; }
}
