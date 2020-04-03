using System;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace Armmy
{
    public class StateManager<T> where T : System.Enum
    {
        IState<T> current = default;

        Dictionary<T, IState<T>> states = new Dictionary<T, IState<T>>();

        public StateManager() { }

        public void Add(T tag, Action init = null, Action update = null, Action end = null)
        {
            this.states.Add(tag, new ActionState<T>(tag, init, update, end));
        }

        public void Add(IState<T> state)
        {
            this.states.Add(state.Tag, state);
        }

        public void Update() => this.current?.Update();

        public void End()
        {
            if (this.current != null)
            {
                this.current.End();
                this.current = null;
            }
        }

        public void Change(IState<T> state)
        {
            this.current?.End();
            this.current = state;
            this.current?.Init();
        }

        public void Change(T tag)
        {
            Assert.IsTrue(this.states.ContainsKey(tag));
            Change(this.states[tag]);
        }

        public void ChangeIfDirrerent(T tag)
        {
            if (IsSame(Current))
            {
                return;
            }
            Change(tag);
        }

        public T Current
        {
            get 
            {
                if (this.current == null)
                {
                    return default(T);
                }
                return this.current.Tag;
            }
        }

        public IState<T> CurrentUnit => this.current;

        public bool IsSame(T target, params T[] states)
        {
            foreach (var t in states)
            {
                if (!target.Equals(t))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
