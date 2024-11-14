using Volo.Abp;

namespace Courses.Tags;

public class TagAlreadyExistsException : BusinessException
{
    public TagAlreadyExistsException(string name)
        : base(CoursesDomainErrorCodes.TagAlreadyExists)
    {
        WithData("name", name);
    }
}