using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTeacherStudio.Data
{
    public class Lesson
    {
        public int LessonID { get; set; }
        [ForeignKey("Teacher")]
        public Guid TeacherID { get; set; }
        public virtual ApplicationUser Teacher { get; set; }
        [ForeignKey("Student")]
        public Guid StudentID { get; set; }
        public virtual ApplicationUser Student { get; set; }
        [ForeignKey("Studio")]
        public int StudioID { get; set; }
        public virtual Studio Studio { get; set; }
        public DateTime Date { get; set; }
        public float? LessonRate { get; set; }
        public bool? IsPayed { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
