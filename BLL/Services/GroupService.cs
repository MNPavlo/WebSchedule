using System.Collections.Generic;
using BLL.Objects;
using BLL.Interfaces;
using AutoMapper;

namespace BLL.Services
{
    public class GroupService : Service<Group>, IGroupService
    {
        public GroupService(string conStr) : base(conStr) { }

        public override void Add(Group obj)
        {
            Unit.Groups.Add(Mapper.Map<Group, DAL.Entities.Group>(obj));
            Unit.Complete();
        }

        public override void Remove(Group obj)
        {
            Unit.Groups.Remove(Mapper.Map<Group, DAL.Entities.Group>(obj));
            Unit.Complete();
        }

        public override Group Get(int id)
        {
            return Mapper.Map<Group>(Unit.Groups.Get(id));
        }

        public IEnumerable<Lesson> GetLessons(int id)
        {
            return Mapper.Map<IEnumerable<Lesson>>(Unit.Groups.GetLessons(id));
        }

        public override List<Group> GetAll()
        {
            return Mapper.Map<List<Group>>(Unit.Groups.GetAll());
        }

        public override void Update(int id, Group obj)
        {
            Unit.Groups.Update(id, Mapper.Map<Group, DAL.Entities.Group>(obj));
            Unit.Complete();
        }
    }
}
