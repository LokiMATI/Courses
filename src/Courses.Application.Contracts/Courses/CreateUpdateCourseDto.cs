using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Courses.Courses;

public class CreateUpdateCourseDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; } = DateTime.Now;

    [Required]
    [StringLength(64)]
    public string? Author { get; set; }

    [Required]
    public List<int>? LessonsId { get; set; }
}