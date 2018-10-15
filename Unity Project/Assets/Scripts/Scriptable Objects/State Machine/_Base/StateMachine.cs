using UnityEngine;

namespace Statemachine
{
    [CreateAssetMenu(menuName = "State Machine/State Machine", fileName = "New State Machine")]
    public class StateMachine : ScriptableObject
    {
        public State[] _States;
    }
}