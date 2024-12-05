using Courses.Courses;
using Courses.Tags;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Courses.Lessons;

public class CreateUpdateLessonDto
{
    [Required]
    [StringLength(128)]
    public required string Name { get; set; }

    [Required]
    public Guid CourseId { get; set; }

    public List<Tag>? Tags { get; set; }

    public string? Material { get; set; }
}
