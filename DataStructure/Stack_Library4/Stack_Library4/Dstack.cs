using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Library4
{
    class Dstack<type>
    {
        private int _count;
        private int _capacity;
        private bool _isEmpty;
        private type[] data;

        public int Count
        {
            get
            {
                return _count;
            }
        }
        public bool IsEmpty
        {
            get
            {
                return Count==0;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public Dstack(int capacity)
        {
            this._capacity = capacity;
            _count = 0;
            data = new type[Capacity];
        }


        public void Resize()
        {
            _capacity = Capacity * 2;
            type[] NewArray = new type[_capacity];
            NewArray = data;
            data = new type[_capacity];
            Array.Copy(NewArray, data, NewArray.Length);
        }


        public void push(type value)
        {
            if (Count < Capacity)
            {
                data[Count] = value;
                _count++;
            }
            else
            {
                Resize();
                push(value);
            }
        }

        public type pop()
        {
            if (!IsEmpty)
            {
                return data[--_count];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public type peek()
        {
            if (!IsEmpty)
            {
                return data[_count - 1];

            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public string Print()
        {
            string re = "";
            for (int i = Count - 1; i >= 0; i--)
            {
                re = re + data[i] + " ";
            }
            return re;
        }
    }
}
