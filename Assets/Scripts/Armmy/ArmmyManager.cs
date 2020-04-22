using UnityEngine;

namespace Armmy
{
    public class ArmmyManager : MonoBehaviour
    {
        [SerializeField]
        ArmmyConfig param = default;

        enum State
        { 
            Idle,
            Move,
        }

        StateManager<State> state = new StateManager<State>();

        void Start()
        {
        }
    }
}