using System;
using System.Collections.Generic;

namespace Stateless
{
    public partial class StateMachine<TState, TTrigger>
    {
        class OnTransitionedEvent
        {
            event Action<Transition> _onTransitioned;

            public void Invoke(Transition transition)
            {
                _onTransitioned?.Invoke(transition);
            }
            
            public void Register(Action<Transition> action)
            {
                _onTransitioned += action;
            }
        }
    }
}