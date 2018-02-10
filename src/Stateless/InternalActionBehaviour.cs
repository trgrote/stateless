using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stateless
{
    public partial class StateMachine<TState, TTrigger>
    {
        internal abstract class InternalActionBehaviour
        {
            public abstract void Execute(Transition transition, object[] args);

            public class Sync : InternalActionBehaviour
            {
                readonly Action<Transition, object[]> _action;

                public Sync(Action<Transition, object[]> action)
                {
                    _action = action;
                }

                public override void Execute(Transition transition, object[] args)
                {
                    _action(transition, args);
                }
            }
        }
    }
}
