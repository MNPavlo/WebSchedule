using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class LessonRepository : Repository<Lesson>, ILessonRepository
    {
        public LessonRepository(GeneralContext context)
            : base(context)
        {
        }
        public GeneralContext PlutoContext
        {
            get { return Context as GeneralContext; }
        }
    }
}
