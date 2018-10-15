using UnityEngine;

namespace Statemachine
{
    [CreateAssetMenu(menuName = "State Machine/State", fileName = "New State")]
    public class State : ScriptableObject
    {
        public GameEvent OnStateEnter;
        public GameEvent OnStateExit;

        public Transition[] _Transitions;

        public void CheckTransitions(Manager manager)
        {
            for (int i = 0; i < _Transitions.Length; i++)
            {
                if (_Transitions[i]._Condition.IsTrue)
                {
                    manager.ChangeState(_Transitions[i]._TargetState);
                    break;
                }
            }
        }

        public void EnterState()
        {
            OnStateEnter.Raise();
        }

        public void ExitState()
        {
            OnStateExit.Raise();
        }
    }
}