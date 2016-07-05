using System.Collections;
using System.Collections.Generic;

namespace GenericApp
{
    public interface IMultiDictionary<TK, TV>
    {
        void Add(TK key, TV value);
        bool Remove(TK key);
        bool Remove(TK key, TV value);
        void Clear();
        bool ContainsKey(TK key);
        bool Contains(TK key, TV value);
        ICollection<TK> Keys { get; }
        ICollection<LinkedList<TV>> Values { get; }
        int Count { get; }
    }

    public class MultiDictionary<TK, TV> : IMultiDictionary<TK, TV>, IEnumerable<KeyValuePair<TK, IEnumerable<TV>>>
    {
        public MultiDictionary()
        {
            Dictionary = new Dictionary<TK, LinkedList<TV>>();
            Count = 0;
        }

        public Dictionary<TK, LinkedList<TV>> Dictionary { get; }


        public void Add(TK key, TV value)
        {
            if (Dictionary.ContainsKey(key))
            {
                Dictionary[key].AddLast(value);
            }
            else
            {
                Dictionary.Add(key, new LinkedList<TV>());
                Dictionary[key].AddLast(value);
            }
            ++Count;
        }

        public bool Remove(TK key)
        {
            if (!Dictionary.Remove(key))
                return false;
            --Count;
            return true;
        }

        public bool Remove(TK key, TV value)
        {
            if (!Dictionary.ContainsKey(key))
                return false;
            {
                if (!Dictionary[key].Remove(value))
                    return false;
                --Count;
                return true;
            }
        }
    

        public void Clear()
        {
            Dictionary.Clear();
            Count = 0;
        }

        public bool ContainsKey(TK key)
        {
            return Dictionary.ContainsKey(key);
        }

        public bool Contains(TK key, TV value)
        {
            if (!Dictionary.ContainsKey(key))
                return false;
            return Dictionary[key].Contains(value);
        }



        public ICollection<TK> Keys
        {
            get { return Dictionary.Keys; }
        }

        public ICollection<LinkedList<TV>> Values
        {
            get { return Dictionary.Values; }
        }

        public int Count { get; private set; }

        public IEnumerator<KeyValuePair<TK, IEnumerable<TV>>> GetEnumerator()
        {
            var list = new List<KeyValuePair<TK, IEnumerable<TV>>>();

            foreach (var item in Dictionary)
            {
                list.Add(new KeyValuePair<TK, IEnumerable<TV>>(item.Key, item.Value));
            }

            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}