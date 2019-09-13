using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class ListMethods
    {
        private int _index = 0;
        private int _sizeArray = 1;
        private int[] _items = new int[1];

        public void Add(int value)
        {
            if (_items[_index] != 0)
            {
                _index++;
                _sizeArray++;
                Array.Resize(ref _items, _sizeArray);
            }
            _items[_index] = value;
        }

        public int Get(int index)
        {
            return 0;
        }
    }
}