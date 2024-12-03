using System;
using Volo.Abp.Application.Dtos;

namespace Courses.Lessons;

public class LessonDto : AuditedEntityDto<Guid>
{
    public required string Name { get; set; }

    public Guid? CourseId { get; set; }

    public string? Material { get; set; }
}
