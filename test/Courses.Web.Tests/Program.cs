using Microsoft.AspNetCore.Builder;
using Courses;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<CoursesWebTestModule>();

public partial class Program
{
}
