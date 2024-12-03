using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Courses.Lessons;

public class CreateUpdateLessonDto
{
    [Required]
    [StringLength(128)]
    public required string Name { get; set; }

    public Guid? CourseId { get; set; }

    public string? Material { get; set; }
}
