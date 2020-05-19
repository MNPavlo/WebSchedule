using System.Collections.Generic;

namespace BLL.Objects
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public string Post { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
