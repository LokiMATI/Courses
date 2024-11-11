﻿using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Courses.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class CoursesDbContextFactory : IDesignTimeDbContextFactory<CoursesDbContext>
{
    public CoursesDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        CoursesEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<CoursesDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new CoursesDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Courses.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
