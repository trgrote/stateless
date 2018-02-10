using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stateless
{
    public partial class StateMachine<TState, TTrigger>
    {
        internal abstract class ExitActionBehavior
        {
            readonly Reflection.InvocationInfo _actionDescription;

            public abstract void Execute(Transition transition);

            protected ExitActionBehavior(Reflection.InvocationInfo actionDescription)
            {
                _actionDescription = actionDescription ?? throw new ArgumentNullException(nameof(actionDescription));
            }

            internal Reflection.InvocationInfo Description => _actionDescription;

            public class Sync : ExitActionBehavior
            {
                readonly Action<Transition> _action;

                public Sync(Action<Transition> action, Reflection.InvocationInfo actionDescription) : base(actionDescription)
                {
                    _action = action;
                }

                public override void Execute(Transition transition)
                {
                    _action(transition);
                }
            }
        }
    }
}
