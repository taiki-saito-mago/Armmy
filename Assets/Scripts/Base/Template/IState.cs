namespace Armmy
{
    // ジェネリック
    public interface IState<T> where T : System.Enum
    { 
        T Tag { get; }
        void Init();
        void Update();
        void End();
    }
}
