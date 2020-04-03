using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Armmy
{
    public class ArmmyManager : MonoBehaviour
    {
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