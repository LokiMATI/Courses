using System.Threading.Tasks;

namespace Courses.Data;

public interface ICoursesDbSchemaMigrator
{
    Task MigrateAsync();
}
