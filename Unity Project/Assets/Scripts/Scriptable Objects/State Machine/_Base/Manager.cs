using UnityEngine;

namespace Statemachine
{
    public class Manager : MonoBehaviour
    {
        public State _CurrentState;

        public StateMachine _StateMachine;

        private void Update()
        {
            //   _CurrentState.CheckTransitions(this);
        }

        public void ChangeState(State newState)
        {
            _CurrentState.ExitState();
            _CurrentState = newState;
            _CurrentState.EnterState();
        }
    }
}