using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Services;
using AnnouncementAPI.Dtos;

namespace AnnouncementAPI.Abstracts
{
    public interface IAnnouncementsService :IApplicationService
    {
        Task<List<AnnouncementDto>> GetListAsync();
        Task<AnnouncementDto> CreateAsync(string title, string content, DateTime createdDate);
        Task DeleteAsync(Guid id);
    }
}
