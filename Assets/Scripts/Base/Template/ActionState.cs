using System;

namespace Armmy
{
    public class ActionState<T> : IState<T> where T : System.Enum
    {
        T tag;
        Action init;
        Action update;
        Action end;

        static void Null() { }

        public ActionState(T tag, Action init, Action update, Action end)
        {
            this.tag = tag;
            this.init = init ?? Null;
            this.update = update ?? Null;
            this.end = end ?? Null;
        }

        public T Tag => this.tag;
        public void Init() => this.init();
        public void Update() => this.update();
        public void End() => this.end();
    }
}
