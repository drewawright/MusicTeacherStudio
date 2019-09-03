using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTeacherStudio.Data
{
    public class StudentInfo
    {
        public int StudentInfoID { get; set; }
        public string ParentsNames { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
        public string Grade { get; set; }
        public virtual ICollection<Studio> Studios { get; set; }
    }
}
