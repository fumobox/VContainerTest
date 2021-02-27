using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace CubeDemo
{
    public class SceneLifetimeScope : LifetimeScope
    {
        [SerializeField] private CubeView _cubeView;

        protected override void Configure(IContainerBuilder builder)
        {
            Debug.Log("SceneLifetimeScope.Configure()");

            // クラスを登録する。必要になった時にインスタンス化される。
            // Transient
            builder.Register<CubeModel>(Lifetime.Singleton);

            // SerializeFieldから登録できる。
            builder.RegisterInstance(_cubeView);

            // ヒエラルキーから探して登録もできる。
            builder.RegisterComponentInHierarchy<UIView>();

            // エントリーポイントとして登録しておくと、自動でインスタンスが生成される。
            builder.RegisterEntryPoint<CubeDemoPresenter>(Lifetime.Scoped);
        }
    }
}

