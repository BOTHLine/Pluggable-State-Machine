using UnityEngine;

namespace Statemachine
{
    [System.Serializable]
    public struct Transition
    {
        public Condition _Condition;
        public State _TargetState;
    }
}