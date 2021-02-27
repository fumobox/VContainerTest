using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ScopeDemo
{
    public class ScopeDemoChildLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            Debug.Log("ScopeDemoChildLifetimeScope.Configure()");
            builder.Register<DemoModelChild>(Lifetime.Singleton);
            builder.Register<Dog>(Lifetime.Transient).As<IAnimal>();
        }
    }

    public class DemoModelChild
    {
        public int Count { get; }

        public DemoModelChild()
        {
            Debug.Log("DemoModelChild.Construct()");
            Count++;
        }
    }

}



