using System;

namespace MyList
{
    public class LinkedList
    {
        public int _data;
        public LinkedList _next;
        public LinkedList(int value)
        {
            _data = value;
            _next = null;
        }

        public void Print()
        {
            Console.WriteLine(_data);
            if (_next!=null)
            {
                _next.Print();
            }
        }
        
    }
    public class ListMethods
    {
        private int _index;
        private int[] _items;
        private int _sizeArray;

        public ListMethods()
        {
            _items = new int[0];
        }

        public void Add(int value)

        {
            Resize();
            _items[_index] = value;
            _index++;
        }

        public int Get(int index)
        {
            int value = _items[index];
            return value;
        }

        public void RemoveAt(int index)
        {
            int[] newItems = new int[_index - 1];
            for (int i = 0; i < newItems.Length; i++)
            {
                if (i < index)
                    newItems[i] = _items[i];
                else
                    newItems[i] = _items[i + 1];
            }

            //for (int i = 0; i < index; i++)
            //    newItems[i] = _items[i];

            //for (int i = index; i < newItems.Length; i++)
            //    newItems[i] = _items[i + 1];

            _items = newItems;
            _index = _items.Length;
        }

        private void Resize()
        {
            int[] newItems = new int[_index + 1];

            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            _items = newItems;
        }
        public int Count()
        {
            _sizeArray = _index;
            return _sizeArray;
        }
    }
}