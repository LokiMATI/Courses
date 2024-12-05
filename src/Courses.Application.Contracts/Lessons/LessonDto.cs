using System;
using Volo.Abp.Application.Dtos;
using Courses.Courses;
using Courses.Tags;
using System.Collections.Generic;

namespace Courses.Lessons;

public class LessonDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public Course Course { get; set; }

    public List<Tag>? Tags { get; set; }

    public string? Material { get; set; }
}
