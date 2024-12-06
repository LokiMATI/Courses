using Courses.Lessons;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Courses.Courses
{
    public class CourseDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string? Author { get; set; }
    }
}
