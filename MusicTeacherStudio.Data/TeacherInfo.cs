using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTeacherStudio.Data
{
    public class TeacherInfo
    {
        public int TeacherInfoID { get; set; }
        public string WebsiteURL { get; set; }
        public int Age { get; set; }
        public string ProfileDescription { get; set; }
        public virtual ICollection<Studio> Studios { get; set; }
    }
}
