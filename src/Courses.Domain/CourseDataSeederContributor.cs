using System;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Courses.Courses;
using Courses.Lessons;
using Courses.Tags;
using System.Threading.Tasks;

namespace Courses
{
    public class CourseDataSeederContributor
    : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Course, Guid> _courseRepository;
        private readonly IRepository<Lesson, Guid> _lessonRepository;
        private readonly IRepository<Tag, Guid> _tagRepository;

        public CourseDataSeederContributor(IRepository<Course, Guid> courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseDataSeederContributor(IRepository<Lesson, Guid> lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public CourseDataSeederContributor(IRepository<Tag, Guid> tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _courseRepository.GetCountAsync() <= 0)
            {
                await _courseRepository.InsertAsync(new Course
                {
                    Name = "Обучающий курс",
                    PublishDate = DateTime.Now,
                    Author = "Lucky"
                });
            }

            if (await _lessonRepository.GetCountAsync() <= 0)
            {
                await _lessonRepository.InsertAsync(new Lesson
                {
                    Name = "Обучающий урок",
                    PublishDate = DateTime.Now
                });
            }

            if (await _tagRepository.GetCountAsync() <= 0)
            {
                await _tagRepository.InsertAsync(new Tag
                {
                    TagName = "Начало"
                });
            }
        }
    }
}
