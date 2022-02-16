using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class ControlClass<T> : IEnumerable
    {
        Hashtable table = new Hashtable();
        private int _count;

        public void Add(object key, object value)
        {
            table.Add(key,value);
            _count++;
        }

        public void Remove(object value)
        {
            table.Remove((T)value);
            _count--;
        }

        public void RemoveAt(int value)
        {
            table.Remove(value);
            _count--;
        }

        public bool Contains(object value)
        {
            return table.Contains((T)value);
        }

        public void Print()
        {
            foreach (T item in table)
            {
                Console.WriteLine($"Элемент: {item.ToString()}");
            }
        }

        public T Value(int index)
        {
            return (T)table[index];
        }

        public void Clear()
        {
            table.Clear();
            _count = 0;
        }

    

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public object this[object key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public ICollection Keys => throw new NotImplementedException();

        public ICollection Values => throw new NotImplementedException();

        public int Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = 0;
            }
        }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();
    }
}
