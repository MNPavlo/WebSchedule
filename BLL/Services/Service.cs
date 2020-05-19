using System.Collections.Generic;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL;
using Ninject.Modules;

namespace BLL.Services
{
    public abstract class Service<TObject> : IService<TObject> where TObject : class
    {
        public IUnitOfWork Unit { get; }

        public Service(string conStr)
        {
            Unit = new UnitOfWork(new GeneralContext(conStr));
        }

        public abstract void Add(TObject obj);
        public abstract void Remove(TObject obj);
        public abstract TObject Get(int id);
        public abstract List<TObject> GetAll();
        public abstract void Update(int id, TObject obj);

        public void Dispose()
        {
            Unit.Dispose();
        }
    }

    public class BllNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
