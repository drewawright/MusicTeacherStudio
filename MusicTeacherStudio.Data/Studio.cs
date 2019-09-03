using System.Collections.Generic;

namespace MusicTeacherStudio.Data
{
    public class Studio
    {
        public int StudioID { get; set; }
        public virtual ICollection<ApplicationUser> Members { get; set; }
        public virtual ICollection<StudioAssignment> StudioAssignments { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}