﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Courses.Lessons;

public class CreateUpdateLessonDto
{
    [Required]
    [StringLength(128)]
    public required string Name { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; }

    [Required]
    public int CourseId { get; set; }

    [Required]
    [StringLength(100000)]
    public string? Material { get; set; }
}
