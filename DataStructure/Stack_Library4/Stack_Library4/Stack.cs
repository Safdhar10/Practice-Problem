using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Library4
{
    public class Stack
    {
        private int _count;
        private int _capacity;
        private bool _isEmpty;
        private int[] _data;

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

        public Stack(int capacity)
        {
            this.Capacity = capacity;
            Count = 0;
            _data = new int[Capacity];
        }



        public void push(int value)
        {
            if (Count != Capacity)
            {
                _data[Count++] = value;
            }
            else
            {
                throw new InvalidOperationException("Stack Overflow");
            }
        }

        public int pop()
        {
            if (!IsEmpty)
            {
                return _data[--Count];
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
                return _data[Count - 1];
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
                re = re + _data[i] + " ";
            }
            return re;
        }
    }
}
