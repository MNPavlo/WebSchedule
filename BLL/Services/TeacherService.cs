using System.Collections.Generic;
using BLL.Objects;
using BLL.Interfaces;
using AutoMapper;

namespace BLL.Services
{
    public class TeacherService : Service<Teacher>, ITeacherService
    {
        public TeacherService(string conStr) : base(conStr) { }

        public override void Add(Teacher obj)
        {
            Unit.Teachers.Add(Mapper.Map<Teacher, DAL.Entities.Teacher>(obj));
            Unit.Complete();
        }

        public override void Remove(Teacher obj)
        {
            Unit.Teachers.Remove(Mapper.Map<Teacher, DAL.Entities.Teacher>(obj));
            Unit.Complete();
        }

        public override Teacher Get(int id)
        {
            return Mapper.Map<Teacher>(Unit.Teachers.Get(id));
        }

        public IEnumerable<Lesson> GetLessons(int id)
        {
            return Mapper.Map<IEnumerable<Lesson>>(Unit.Teachers.GetLessons(id));
        }

        public override List<Teacher> GetAll()
        {
            return Mapper.Map<List<Teacher>>(Unit.Teachers.GetAll());
        }

        public override void Update(int id, Teacher obj)
        {
            Unit.Teachers.Update(id, Mapper.Map<Teacher, DAL.Entities.Teacher>(obj));
            Unit.Complete();
        }
    }
}
