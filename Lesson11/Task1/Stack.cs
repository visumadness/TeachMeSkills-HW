using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Stack<T> : IEnumerable<T>
    {
        private LinkedList<T> _items = new LinkedList<T>();

        public void Push(T item)
        {
            _items.AddLast(item);
        }

        public T Pop()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            T lastItem = _items.Last.Value;
            _items.RemoveLast();
            return lastItem;
        }

        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return _items.Last.Value;
        }

        public bool IsEmpty()
        {
            return _items.Count == 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
