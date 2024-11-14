using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Courses.Lessons;

public class Lesson : AuditedAggregateRoot<Guid>
{
    public required string Name { get; set; }

    public DateTime PublishDate { get; set; }

    public required int CourseId { get; set; }

    public string? Material {  get; set; }
}
