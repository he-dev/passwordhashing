using System.Collections.Generic;

namespace PH.Web
{
    public class LimitedQueue<T> : Queue<T>
    {
        private readonly int _limit;

        public LimitedQueue(int limit) : base(limit)
        {
            _limit = limit;
        }

        public new void Enqueue(T item)
        {
            while (Count >= _limit)
            {
                Dequeue();
            }
            base.Enqueue(item);
        }
    }
}