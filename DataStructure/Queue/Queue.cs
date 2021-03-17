using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_DataStructure
{
    public class Queue<T>
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
        public Queue(int Capacity)
        {
            this._capacity = Capacity;
            _data = new T[Capacity];
            _count = 0;
            _tail = -1;
            _head = -1;
        }
        public void EnQueue(T value)
        {
            if (_count < _capacity)
            {
                if (_tail == (_capacity - 1))
                {
                    _tail = -1;
                }
                if (_count == 0)
                {
                    _head = 0;
                }
                _data[++_tail] = value;
                _count++;
            }
            else
            {
                Resize();
                EnQueue(value);
            }
        }
        public T DeQueue()
        {
            if(!IsEmpty)
            {
                    if(_head==(_capacity))
                    {
                        _head = 0;
                    }
                    _count--;
                    return _data[_head++];
            }
            else
            {
                throw new InvalidOperationException("Queue is empty");
            }
        }
        public T Peek()
        {
            if(!IsEmpty)
            {
                return _data[_head];
            }
            else
            {
                throw new InvalidOperationException("Queue is Empty");
            }
        }
        public string Print()
        {
            if(!IsEmpty)
            {
                int _h = _head;
                int _t = 0;
                StringBuilder sb = new StringBuilder();
                for(int i=1;i<=_count;i++)
                {
                    if(_h<_capacity)
                    {
                        sb.Append(_data[_h++]+" ");

                    }
                    else
                    {
                        sb.Append(_data[_t++]+" ");
                    }
                }
                return sb.ToString();
            }
            else
            {
                throw new InvalidOperationException("Queue is empty");
            }
        }
        public void Clear()
        {
            _data = new T[_capacity];
            _count = 0;
            _tail = -1;
            _head = -1;
        }
        public void Resize()
        {
            if(!IsEmpty)
            {
                T[] NewArray = new T[_capacity*=2];
                int _h = _head;
                int _t = 0;
                for(int i=0;i<_count;i++)
                {
                    if(_h<_count)
                    {
                        NewArray[i] = _data[_h];
                    }
                    else
                    {
                        NewArray[i] = _data[_t];
                    }
                }
                _data = NewArray;
            }
            else
            {
                throw new InvalidOperationException("Queue is empty");
            }
        }
    }
}
