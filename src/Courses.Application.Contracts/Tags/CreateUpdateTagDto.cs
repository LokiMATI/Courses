using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Courses.Tags;

public class CreateUpdateTagDto
{
    [Required]
    [StringLength(32)]
    public required string Name { get; set; }

    [Required]
    public List<int>? CoursesId { get; set; }

    [Required]
    public List<int>? LessonsId { get; set; }
}