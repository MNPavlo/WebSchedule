using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Objects;
using AutoMapper;

namespace BLL.Services
{
    public class LessonService : Service<Lesson>, ILessonService
    {
        public LessonService(string conStr) : base(conStr) { }

        public override void Add(Lesson obj)
        {
            Unit.Lessons.Add(Mapper.Map<Lesson, DAL.Entities.Lesson>(obj));
            Unit.Complete();
        }

        public override void Remove(Lesson obj)
        {
            Unit.Lessons.Remove(Mapper.Map<Lesson, DAL.Entities.Lesson>(obj));
            Unit.Complete();
        }

        public override Lesson Get(int id)
        {
            return Mapper.Map<Lesson>(Unit.Lessons.Get(id));
        }

        public override List<Lesson> GetAll()
        {
            return Mapper.Map<List<Lesson>>(Unit.Lessons.GetAll());
        }

        public override void Update(int id, Lesson obj)
        {
            Unit.Lessons.Update(id, Mapper.Map<Lesson, DAL.Entities.Lesson>(obj));
            Unit.Complete();
        }
    }
}
