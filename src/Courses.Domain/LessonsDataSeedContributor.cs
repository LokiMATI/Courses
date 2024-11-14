using System;
using System.Threading.Tasks;
using Courses.Lessons;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Courses;

public class LessonsDataSeedContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Lesson, Guid> _lessonRepository;

    public LessonsDataSeedContributor(IRepository<Lesson, Guid> lessonRepository)
    {
        _lessonRepository = lessonRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _lessonRepository.GetCountAsync() <= 0)
        {
            await _lessonRepository.InsertAsync(
                new Lesson
                {
                    Name = "Обучающий урок",
                    PublishDate = DateTime.Now,
                    CourseId = 0,
                    Material = "Данный урок и данный курс являются обучающими и буферными соответсвенно.\nЕсли не указывать CourseId, то курсы по умолчанию буду присваиваться буферному курсу, то есть курсу с Id 0."
                },
                autoSave: true
            );
        }
    }
}
