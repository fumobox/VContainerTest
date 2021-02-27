using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ScopeDemo
{
    public class ScopeDemoParentLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            Debug.Log("ScopeDemoParentLifetimeScope.Configure()");
            builder.Register<DemoModelParent>(Lifetime.Singleton);
            builder.Register<Cat>(Lifetime.Transient).As<IAnimal>();
        }
    }

    public class DemoModelParent
    {
        public int Count { get; }

        public DemoModelParent()
        {
            Debug.Log("DemoModelParent.Construct()");
            Count++;
        }
    }

}



