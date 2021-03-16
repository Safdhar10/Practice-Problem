using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_DataStructure
{
    class DeqQueue<T>
    {
        private T[] _data;
        private int _count;
        private int _capacity;
        private bool _isEmpty;
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public bool IsEmpty
        {
            get
            {
                if (Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private int _tail;
        private int _head;
        public DeqQueue(int Capacity)
        {
            this._capacity = Capacity;
            _data = new T[Capacity];
            _count = 0;
            _tail = -1;
            _head = 0;
        }
        public void Enqueue(T value)
        {
            if(_count<_capacity)
            {
                if(_tail==(_capacity-1))
                {
                    _tail = -1;
                }
                _data[++_tail] = value;
                _count++;
            }
            else
            {
                throw new InvalidOperationException("DeqQueue is full");
            }
        }
        public void Push(T value)
        {
            if (_count < _capacity)
            {
                if (_tail == (_capacity - 1))
                {
                    _tail = -1;
                }
                _data[++_tail] = value;
                _count++;
            }
            else
            {
                throw new InvalidOperationException("DeqQueue is full");
            }
        }
        public void Dequeue()
        {
            if (!IsEmpty)
            {
                if (_head == (_capacity))
                {
                    _head = 0;
                }
                _count--;
                _head++;
            }
            else
            {
                throw new InvalidOperationException("Queue is empty");
            }
        }
        public void Pop()
        {
            if (!IsEmpty)
            {
                if (_tail == 0)
                {
                    _tail = _capacity-1;
                }
                _count--;
                _tail--;
            }
            else
            {
                throw new InvalidOperationException("Queue is empty");
            }
        }
    }
}
