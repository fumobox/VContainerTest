using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ScopeDemo
{
    public class ScopeDemoLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            Debug.Log("ScopeDemoLifetimeScope.Configure()");
            builder.Register<DemoModel>(Lifetime.Singleton);
            //builder.Register<DemoModelParent>(Lifetime.Singleton);
            //builder.Register<Dog>(Lifetime.Transient).As<IAnimal>();
            builder.Register<Lion>(Lifetime.Transient).As<IAnimal>();
            builder.RegisterEntryPoint<DemoPresenter>(Lifetime.Scoped);
        }
    }

    public class DemoPresenter: IInitializable
    {
        private DemoModel _demoModel;
        private DemoModelParent _demoModelParent;
        private RootSingleton _rootSingleton;

        public DemoPresenter(DemoModel demoModel, DemoModelParent parent, RootSingleton rootSingleton, IAnimal animal)
        {
            Debug.Log("DemoPresenter.Construct()");
            _demoModel = demoModel;
            _demoModelParent = parent;
            _rootSingleton = rootSingleton;
            animal.Hello();
        }

        public void Initialize()
        {
            Debug.Log("DemoPresenter.Initialize()");
            _demoModel.Hello();
            _rootSingleton.Hello();
        }
    }

    public class DemoModel
    {
        private int _count;

        public DemoModel()
        {
            Debug.Log("DemoModel.Construct()");
        }

        public void Hello()
        {
            Debug.Log($"DemoModel: Hello {_count++}");
        }
    }

    public interface IAnimal
    {
        void Hello();
    }

    public class Dog : IAnimal
    {
        public void Hello()
        {
            Debug.Log("ワン");
        }
    }

    public class Cat : IAnimal
    {
        public void Hello()
        {
            Debug.Log("ニャン");
        }
    }

    public class Lion : IAnimal
    {
        public void Hello()
        {
            Debug.Log("ガオー");
        }
    }

}



