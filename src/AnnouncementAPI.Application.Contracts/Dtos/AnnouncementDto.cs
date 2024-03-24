using System;
using System.Collections.Generic;
using System.Text;

namespace AnnouncementAPI.Dtos
{
    public class AnnouncementDto
    {
        public Guid Id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime createdDate { get; set; }

    }
}
