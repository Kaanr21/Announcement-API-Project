using AnnouncementAPI.Abstracts;
using AnnouncementAPI.Dtos;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Xunit;

namespace AnnouncementAPI.Announcements
{
    public abstract class AnnouncementsService_Tests<TStartupModule> : AnnouncementAPITestBase<TStartupModule>
    where TStartupModule : IAbpModule
    {
        private readonly IAnnouncementsService _announcementsService;

        protected AnnouncementsService_Tests()
        {
            _announcementsService = GetRequiredService<IAnnouncementsService>();
        }


        [Fact]
        public async Task Should_Get_List_Of_Announcement()
        {        
            var result = await _announcementsService.GetListAsync(

            );
         
            //result.TotalCount.ShouldBeGreaterThan(0);
            //result.Items.ShouldContain(b => b.Name == "1984");

        }
        [Fact]
        public async Task Should_Not_Create_A_Announcement_Without_Name()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _announcementsService.CreateAsync( "","asd",DateTime.Now );
            });

            exception.ValidationErrors
                .ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
        }


        [Fact]
        public async Task Should_Create_A_Valid_Announcement()
        {
            //Act
            var result = await _announcementsService.CreateAsync(
               "Test", "Test", DateTime.Now

            );

            //Assert
            result.Id.ShouldNotBe(Guid.Empty);
            result.title.ShouldBe("Test");
        }



    }


}
