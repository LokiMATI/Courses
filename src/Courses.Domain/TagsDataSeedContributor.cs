using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courses.Tags;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Courses;

public class TagsDataSeedContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Tag, Guid> _tagRepository;

    public TagsDataSeedContributor(IRepository<Tag, Guid> tagRepository)
    {
        _tagRepository = tagRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _tagRepository.GetCountAsync() <= 0)
        {
            List<int> ints = new List<int>();
            ints.Add(0);
            await _tagRepository.InsertAsync(
                new Tag
                {
                    TagName = "БазовыйТэг",
                    CoursesId = ints.ToList(),
                    LessonsId = ints.ToList(),

                },
                autoSave: true
            );
        }
    }
}
