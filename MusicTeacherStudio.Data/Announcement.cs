using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTeacherStudio.Data
{
    public class Announcement
    {
        public int AnnouncementID { get; set; }
        public string AnnouncementText { get; set; }
        [ForeignKey("Announcer")]
        public Guid AnnouncerID { get; set; }
        public virtual ApplicationUser Announcer { get; set; }
        [ForeignKey("Studio")]
        public int StudioID { get; set; }
        public virtual Studio Studio { get; set; }
    }
}
