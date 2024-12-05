using Courses.Lessons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Courses.Tags;

public class CreateUpdateTagDto
{
    [Required]
    [StringLength(32)]
    public string TagName { get; set; }

    [Required]
    public List<Lesson> Lessons { get; set; }
}