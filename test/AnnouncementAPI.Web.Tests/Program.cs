using Microsoft.AspNetCore.Builder;
using AnnouncementAPI;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<AnnouncementAPIWebTestModule>();

public partial class Program
{
}
