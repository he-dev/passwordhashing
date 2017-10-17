using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace PH.Web
{
    public class ApplicationState
    {
        private static readonly ConcurrentDictionary<string, object> Locks = new ConcurrentDictionary<string, object>();
        private readonly Dictionary<string, LimitedQueue<string>> _recentHashes = new Dictionary<string, LimitedQueue<string>>();

        public IList<string> GetRecentHashes(string algorithm)
        {
            List<string> result = null;
            lock (Locks.GetOrAdd(algorithm, new object()))
            {
                if (_recentHashes.ContainsKey(algorithm))
                {
                    result = _recentHashes[algorithm]?.ToList();
                }
            }
            return result ?? new List<string>();
        }

        public void AddPlainText(string algorithm, string plainText)
        {
            lock (Locks.GetOrAdd(algorithm, new object()))
            {
                LimitedQueue<string> queue;
                if (_recentHashes.ContainsKey(algorithm))
                {
                    queue = _recentHashes[algorithm];
                }
                else
                {
                    queue = new LimitedQueue<string>(10);
                    _recentHashes.Add(algorithm, queue);
                }

                if (!queue.Contains(plainText))
                {
                    queue.Enqueue(plainText);
                }
            }
        }
    }
}