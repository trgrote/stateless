using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stateless
{
    public partial class StateMachine<TState, TTrigger>
    {
        abstract class UnhandledTriggerAction
        {
            public abstract void Execute(TState state, TTrigger trigger, ICollection<string> unmetGuards);

            internal class Sync : UnhandledTriggerAction
            {
                readonly Action<TState, TTrigger, ICollection<string>> _action;

                internal Sync(Action<TState, TTrigger, ICollection<string>> action = null)
                {
                    _action = action;
                }

                public override void Execute(TState state, TTrigger trigger, ICollection<string> unmetGuards)
                {
                    _action(state, trigger, unmetGuards);

                }
            }
        }
    }
}
