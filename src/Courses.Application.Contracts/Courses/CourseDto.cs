﻿using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Courses.Courses
{
    public class CourseDto : AuditedEntityDto<Guid>
    {
        public required string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public string? Author { get; set; }

        public List<int>? LessonsId { get; set; }
    }
}