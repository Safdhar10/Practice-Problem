using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackConsoleApp
{
    class TwoStack<T>
    {
        private int _count1;
        private int _capacity;
        private bool _isEmpty1; 
        private int _count2;
        private bool _isEmpty2;
        private T[] _data;

        public int Count1
        {
            get
            {
                return _count1;
            }
        }
        public bool IsEmpty1
        {
            get
            {
                return Count1 == 0;
            }
        }
        public int Count2
        {
            get
            {
                return _count2;
            }
        }
        public bool IsEmpty2
        {
            get
            {
                return Count2 == Capacity;
            }
        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public TwoStack(int capacity=10)
        {
            this._capacity = capacity;
            _count1 = 0;
            _count2 = capacity;
            _data = new T[Capacity];
        }

        public void Stack1_Push(T value)
        {
            if (Count1<Count2)
            {
                _data[_count1++] = value;
            }
            else
            {
                throw new InvalidOperationException("Stack Overflow");
            }
        }
        public void Stack2_Push(T value)
        {
            if (Count1<Count2)
            {
                _data[--_count2] = value;
            }
            else
            {
                throw new InvalidOperationException("Stack Overflow");
            }
        }

        public T Stack1_Pop()
        {
            if (!IsEmpty2)
            {
                return _data[--_count1];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }
        public T Stack2_Pop()
        {
            if (!IsEmpty2)
            {
                return _data[_count2++];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public T Stack1_Peek()
        {
            if (!IsEmpty1)
            {
                return _data[_count1 - 1];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }
        public T Stack2_Peek()
        {
            if (!IsEmpty2)
            {
                return _data[_count2];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public string Stack1_Print()
        {
            if (!IsEmpty1)
            {
                StringBuilder re = new StringBuilder();
                for (int i = Count1 - 1; i >= 0; i--)
                {
                    re.Append(_data[i] + " ");
                }
                return re.ToString();
            }
            else
            {
                throw new InvalidOperationException("The Stack is Empty.");
            }
        }
        public string Stack2_Print()
        {
            if (!IsEmpty2)
            {
                StringBuilder re = new StringBuilder();
                for (int i = Count2; i <Capacity; i++)
                {
                    re.Append(_data[i] + " ");
                }
                return re.ToString();
            }
            else
            {
                throw new InvalidOperationException("The Stack is Empty.");
            }
        }

        public override string ToString()
        {
            StringBuilder re = new StringBuilder();
            for (int i = Count1 - 1; i >= 0; i--)
            {
                re.Append(_data[i] + " ");
            }
            return re.ToString();
        }
    }
}
