using System;
using System.Collections.Generic;
using System.Text;
using DAL.Repositories;
using DAL.Interfaces;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GeneralContext _context;

        public UnitOfWork(GeneralContext context)
        {
            _context = context;
            Lessons = new LessonRepository(_context);
            Teachers = new TeacherRepository(_context);
            Groups = new GroupRepository(_context);
        }

        public ILessonRepository Lessons { get; private set; }
        public ITeacherRepository Teachers { get; private set; }
        public IGroupRepository Groups { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
