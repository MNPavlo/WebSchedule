using System.Collections.Generic;

namespace BLL.Objects
{
    public class Group
    {
        public int GroupId { get; set; }

        public int CourseNumber { get; set; }
        public int GroupNumber { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
