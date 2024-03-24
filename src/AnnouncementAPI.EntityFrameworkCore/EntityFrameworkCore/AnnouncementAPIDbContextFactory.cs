using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AnnouncementAPI.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AnnouncementAPIDbContextFactory : IDesignTimeDbContextFactory<AnnouncementAPIDbContext>
{
    public AnnouncementAPIDbContext CreateDbContext(string[] args)
    {
        AnnouncementAPIEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AnnouncementAPIDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AnnouncementAPIDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AnnouncementAPI.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
