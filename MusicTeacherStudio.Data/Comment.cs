using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTeacherStudio.Data
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        [ForeignKey("Assignment")]
        public int? AssignmentID { get; set; }
        public virtual Assignment Assignment { get; set; }
        [ForeignKey("StudioAssignment")]
        public int? StudioAssignmentID { get; set; }
        public virtual Assignment StudioAssignment { get; set; }
        [ForeignKey("Commenter")]
        public Guid CommenterID { get; set; }
        public virtual ApplicationUser Commenter { get; set; }

    }
}
