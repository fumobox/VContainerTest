using UnityEngine;
using VContainer.Unity;

namespace CubeDemo
{
    public class CubeDemoPresenter: IInitializable, ITickable
    {
        private CubeView _cubeView;
        private CubeModel _cubeModel;
        private UIView _uiView;

        // コンストラクターインジェクション
        // VContainerによって自動で引数がセットされる。
        public CubeDemoPresenter(CubeModel cubeModel, UIView uiView, CubeView cubeView)
        {
            Debug.Log("CubeDemoPresenter.Construct()");
            _cubeView = cubeView;
            _cubeModel = cubeModel;
            _uiView = uiView;
        }

        // 初期化時に呼ばれる
        public void Initialize()
        {
            Debug.Log("CubeDemoPresenter.Initialize()");
            _cubeModel.RotationSpeed = 20;

            _uiView.OnClick += () =>
            {
                _cubeModel.SetRandomColor();
                _cubeView.SetColor(_cubeModel.Color);
            };
        }

        // 毎フレーム呼ばれる
        public void Tick()
        {
            _cubeView.Rotate(_cubeModel.RotationSpeed);
        }
    }
}