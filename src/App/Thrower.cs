using System;

namespace debug_test
{
    public class Thrower : IPerformer
    {
        public void Do()
        {
            throw new NotImplementedException();
        }
    }

    public class ConditionalPerformer : IPerformer
    {
        private readonly Func<bool> _condition;
        private readonly IPerformer _performer;

        public ConditionalPerformer(Func<bool> condition, IPerformer performer)
        {
            this._condition = condition;
            this._performer = performer;
        }

        public void Do()
        {
            if (this._condition())
            {
                this._performer.Do();
            }
        }
    }
}