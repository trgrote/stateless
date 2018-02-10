using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stateless
{
    public partial class StateMachine<TState, TTrigger>
    {
        internal abstract class DeactivateActionBehaviour
        {
            readonly TState _state;
            readonly Reflection.InvocationInfo _actionDescription;

            protected DeactivateActionBehaviour(TState state, Reflection.InvocationInfo actionDescription)
            {
                _state = state;
                _actionDescription = actionDescription ?? throw new ArgumentNullException(nameof(actionDescription));
            }

            internal Reflection.InvocationInfo Description => _actionDescription;

            public abstract void Execute();

            public class Sync : DeactivateActionBehaviour
            {
                readonly Action _action;

                public Sync(TState state, Action action, Reflection.InvocationInfo actionDescription)
                    : base(state, actionDescription)
                {
                    _action = action;
                }

                public override void Execute()
                {
                    _action();
                }
            }
        }
    }
}
