using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTeacherStudio.Data
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        [ForeignKey("Teacher")]
        public Guid TeacherID { get; set; }
        public virtual ApplicationUser Teacher { get; set; }
        [ForeignKey("Student")]
        public Guid StudentID { get; set; }
        public virtual ApplicationUser Student { get; set; }
        public string AssignmentName { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
