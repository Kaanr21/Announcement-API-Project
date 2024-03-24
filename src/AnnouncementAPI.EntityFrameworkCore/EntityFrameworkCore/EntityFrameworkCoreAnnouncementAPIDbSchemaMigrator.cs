using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AnnouncementAPI.Data;
using Volo.Abp.DependencyInjection;

namespace AnnouncementAPI.EntityFrameworkCore;

public class EntityFrameworkCoreAnnouncementAPIDbSchemaMigrator
    : IAnnouncementAPIDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAnnouncementAPIDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AnnouncementAPIDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AnnouncementAPIDbContext>()
            .Database
            .MigrateAsync();
    }
}
