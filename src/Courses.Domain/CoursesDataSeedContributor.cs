using System;
using System.Threading.Tasks;
using Courses.Courses;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Courses;

public class CoursesDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Course, Guid> _courseRepository;

    public CoursesDataSeederContributor(IRepository<Course, Guid> courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _courseRepository.GetCountAsync() <= 0)
        {
            await _courseRepository.InsertAsync(
                new Course
                {
                    Name = "Первый курс",
                    PublishDate = DateTime.Now,
                    Author = "Lucky"
                },
                autoSave: true
            );
        }
    }
}
