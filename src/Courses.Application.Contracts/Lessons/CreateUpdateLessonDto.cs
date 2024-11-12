using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Courses.Lessons;

public class CreateUpdateLessonDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; }

    public DateTime PublishDate { get; set; }

    [Required]
    public int CourseId { get; set; }

    [Required]
    public string? Material { get; set; }
}
