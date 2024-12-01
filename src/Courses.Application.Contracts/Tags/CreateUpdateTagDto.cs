using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Courses.Tags;

public class CreateUpdateTagDto
{
    [Required]
    [StringLength(32)]
    public string TagName { get; set; }

    public List<Guid>? LessonsId { get; set; }
}