using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace AnnouncementAPI.Entities
{
  
    public class AnnouncementsModel : BasicAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime createdDate { get; set; } = DateTime.Now;
    }
}
