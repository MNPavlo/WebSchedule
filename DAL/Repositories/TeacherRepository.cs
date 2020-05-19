using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(GeneralContext context)
            : base(context)
        {
        }
        public GeneralContext PlutoContext
        {
            get { return Context as GeneralContext; }
        }

        public IEnumerable<Lesson> GetLessons(int id)
        {
            return Get(id).Lessons;
        }
    }
}
