using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace HelloWorld
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<HelloWorldService>(Lifetime.Singleton);
            builder.RegisterEntryPoint<GamePresenter>(Lifetime.Singleton);
        }
    }

    public class HelloWorldService
    {
        public void Hello()
        {
            Debug.Log("Hello World");
        }
    }

    public class GamePresenter: IInitializable
    {
        readonly HelloWorldService helloWorldService;

        public GamePresenter(HelloWorldService helloWorldService)
        {
            this.helloWorldService = helloWorldService;
        }

        public void Initialize()
        {
            helloWorldService.Hello();
        }
    }
}

