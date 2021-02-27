using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ScopeDemo
{
    public class ProjectLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            Debug.Log("ProjectLifetimeScope.Configure()");

            builder.Register<RootSingleton>(Lifetime.Singleton);
        }
    }

    public class RootSingleton
    {
        private int _count;

        public RootSingleton()
        {
            Debug.Log("RootSingleton.Construct()");
        }

        public void Hello()
        {
            Debug.Log($"RootSingleton: Hello {_count++}");
        }
    }
}

