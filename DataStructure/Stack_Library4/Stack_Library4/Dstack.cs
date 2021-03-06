using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Library4
{
    class Dstack
    {
        private int _count;
        private int _capacity;
        private bool _isEmpty;
        private int[] data;

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        public bool IsEmpty
        {
            get
            {
                if (Count == 0)
                {
                    _isEmpty = true;
                }
                else
                {
                    _isEmpty = false;
                }
                return _isEmpty;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }

        public Dstack(int capacity)
        {
            this.Capacity = capacity;
            Count = 0;
            data = new int[Capacity];
        }


        public void Resize()
        {
            Capacity = Capacity * 2;
            int[] NewArray = new int[Capacity];
            NewArray = data;
            data = new int[Capacity];
            Array.Copy(NewArray, data, NewArray.Length);
        }


        public void push(int value)
        {
            if (Count != Capacity)
            {
                data[Count] = value;
                Count++;
            }
            else
            {
                Resize();
                push(value);
            }
        }

        public int pop()
        {
            if (!IsEmpty)
            {
                return data[--Count];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public int peek()
        {
            if (!IsEmpty)
            {
                return data[Count - 1];

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
