using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTeacherStudio.Data
{
    public class StudioAssignment
    {
        public int StudioAssignmentID { get; set; }
        public string Name { get; set; }
        public string Book { get; set; }
        public string PageNumber { get; set; }
        public string RecordingURL { get; set; }
        public Guid TeacherID { get; set; }
        public virtual ApplicationUser Teacher { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
