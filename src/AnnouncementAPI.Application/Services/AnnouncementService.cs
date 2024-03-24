using AnnouncementAPI.Abstracts;
using AnnouncementAPI.Dtos;
using AnnouncementAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AnnouncementAPI.Services
{
    

    public class AnnouncementService : ApplicationService, IAnnouncementsService
    {
        private readonly IRepository<AnnouncementsModel,Guid> _announcementsRepository;

        public AnnouncementService(IRepository<AnnouncementsModel, Guid> announcementsRepository)
        {
            _announcementsRepository = announcementsRepository;
        }
        public async Task<List<AnnouncementDto>> GetListAsync()
        {
           
            var items = await _announcementsRepository.GetListAsync();

            return items.Select(items => new AnnouncementDto
            {
                Id = items.Id,
                title = items.title,
                content = items.content,
                createdDate=items.createdDate,
            }).ToList();
        }

        public async Task<AnnouncementDto> CreateAsync(string title,string content , DateTime createdDate)
        {
            var item = await _announcementsRepository.InsertAsync(new AnnouncementsModel 
            {
            title= title,
            content= content,
            createdDate=createdDate,
            
            });

            return new AnnouncementDto
            {
                Id = item.Id,
                content = item.content,
                createdDate = item.createdDate,
                title = item.title
            };
        }

        public async Task DeleteAsync(Guid id)
        {
            await _announcementsRepository.DeleteAsync(id);
        }
    }
}
