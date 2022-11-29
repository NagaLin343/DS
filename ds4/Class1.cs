using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DS4
{
    public class LinkedList<TItem> : IEnumerable<TItem>
    {
         public class Item<TItem>
        {
            public TItem Data { get; set; }
            public Item<TItem> Next { get; set; }
            public Item(TItem data)
            {
                if (data == null)
                {
                    throw new ArgumentNullException(nameof(data));
                }

                Data = data;
            }
            public override string ToString()
            {
                return Data.ToString();
            }
        }
        private Item<TItem> _head = null;

        private Item<TItem> _tail = null;

        private int _count = 0;
        public int Count
        {
            get => _count;
        }

        public void Push(TItem data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            var item = new Item<TItem>(data);
            if (_head == null)
            {
                _head = item;
            }
            else
            {
                _tail.Next = item;
            }
            _tail = item;

            _count++;
        }

        public void Delete(TItem data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            var current = _head;
            Item<TItem> previous = null;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        _head = _head.Next;
                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }
                    _count--;
                    break;
                }
                previous = current;
                current = current.Next;
            }
        }
        public TItem Peek()
        {
            if (_head == null)
            {
                return default;
            }
            return _head.Data;
        }
        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }
        public IEnumerator<TItem> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
