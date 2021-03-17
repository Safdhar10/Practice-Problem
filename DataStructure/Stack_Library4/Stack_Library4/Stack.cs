using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Library4
{
    public class Stack<type>
    {
        private int _count;
        private int _capacity;
        private bool _isEmpty;
        private type[] _data;

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

        public Stack(int capacity)
        {
            this._capacity = capacity;
            _count= 0;
            _data = new type[Capacity];
        }

        public void Push(type value)
        {
            if (Count < Capacity)
            {
                _data[_count++] = value;
            }
            else
            {
                throw new InvalidOperationException("Stack Overflow");
            }
        }

        public type Pop()
        {
            if (!IsEmpty)
            {
                return _data[--_count];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public type Peek()
        {
            if (!IsEmpty)
            {
                return _data[_count - 1];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public string Print()
        {
            if(!IsEmpty)
            {
                return this.ToString();
            }
            else
            {
                throw new InvalidOperationException("The Stack is Empty.");
            }
        }

        public override string ToString()
        {
            StringBuilder re = new StringBuilder();
            for (int i = _count - 1; i >= 0; i--)
            {
                re.Append(_data[i] + " ");
            }
            return re.ToString();
        }
    }
}
