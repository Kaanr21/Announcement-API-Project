using AnnouncementAPI.Abstracts;
using AnnouncementAPI.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AnnouncementAPI.Web.Pages
{
    public class IndexModel : AnnouncementAPIPageModel
    {
        public void OnGet()
        {

        }

        //public List<AnnouncementDto> Announcements { get; set; } = new List<AnnouncementDto>();

        //private readonly IAnnouncementsService _announcementsService;

        //public IndexModel(IAnnouncementsService announcementsService)
        //{
        //    _announcementsService = announcementsService;
        //}

        //public async Task OnGetAsync()
        //{
        //    Announcements = await _announcementsService.GetListAsync();
        //}

    }

}