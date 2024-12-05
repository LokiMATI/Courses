using Courses.Courses;
using System;
using System.ComponentModel.DataAnnotations;

namespace Courses.Lessons;

public class CreateUpdateLessonDto
{
    [Required]
    [StringLength(128)]
    public required string Name { get; set; }

    [Required]
    public Course Course { get; set; }

    public string? Material { get; set; }
}
