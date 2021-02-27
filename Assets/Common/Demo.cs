using UnityEngine;

namespace Common
{
    public class MainClass
    {
        public static void Main()
        {
            // DependencyManagerからIPeopleの実体を取得する。
            IPeople people = DependencyManager.Resolve();
            people.SayHello();
        }
    }

    public class Tanaka: IPeople
    {
        public void SayHello()
        {
            Debug.Log("Hello. I'm Tanaka.");
        }
    }

    public class Yoshida: IPeople
    {
        public void SayHello()
        {
            Debug.Log("Hello. I'm Yoshida.");
        }
    }

    public interface IPeople
    {
        void SayHello();
    }

    // 依存関係を解決するためのクラス
    public static class DependencyManager
    {
        public static IPeople Resolve()
        {
#if DEBUG
            // デバッグ時はTanakaを返す。
            return new Tanaka();
#else
            // 本番ではYoshidaを返す。
            return new Yoshida();
#endif
        }
    }
}