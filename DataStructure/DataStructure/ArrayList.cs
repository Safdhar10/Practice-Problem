using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class ArrayList
    {
        private int _capacity;
        private int[] data;
        private int _count;
        private bool isEmpty;
        public int Count { get => _count; set => _count = value; }
        public ArrayList()
        {
            _capacity = 2;
            isEmpty = true;
            data = new int[_capacity];
        }

        public  void SetArrayState()
        {
            if(Count==0)
            {
                isEmpty = true;
            }
            else
            {
                isEmpty = false;
            }
        }
        public void Print()
        {
            if (!isEmpty)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                for (int i = 0; i < Count-1; i++)
                {
                    sb.Append(data[i] + ",");
                }
                sb.Append(data[Count-1]+"]");
                Console.WriteLine(sb.ToString()); 
            }
            else
            {
                throw new Exception("arraylist is empty");
            }
        }

        public void Resize()
        {
            int[] oldArray = new int[Capacity1];
            Array.Copy(data, oldArray, Capacity1);
            //for(int i=0;i<Capacity1;i++)
            //{
            //    oldArray[i] = data[i];
            //}
            Capacity1 = (Capacity1 * 2);
            data = new int[Capacity1];
            //for(int j=0;j<oldArray.Length;j++)
            //{
            //    data[j] = oldArray[j];
            //}
            Array.Copy(oldArray, data, oldArray.Length);
        }

        public void Add(int value)
        {
            if (Count < _capacity)
            {
                data[Count] = value;
                Count++;
            }
            else
            {
                Resize();
                Add(value);
            }
            SetArrayState();
        }

        public int Get(int index)
        {
            if (index < Count1 && index>=0)
            {
                return data[index];
            }
            else
            {
                return -1;
            }
        }

        public void Set(int index, int value)
        {
                if (index < Count1 && index>=0)
                {
                    data[index] = value;
                }
                else
                {
                    Console.WriteLine("Index was outside the bounds of the array ");
                }
        }

        public void Insert(int index, int value)
        {
            if (index <= Count1 && index>=0)
            {
                if(Count1==Capacity1)
                {
                    Resize();
                }
                for (int i = Count1; i > index; i--)
                {
                    data[i] = data[i - 1];
                }
                data[index] = value;
                Count++;
            }
            else
            {
                Console.WriteLine("Index was outside the bound of the array");
            }

        }

        public void Delete(int index)
        {
            if(Count1!=IsEmpty)
            {
                if (index >= 0 && index < Count1)
                {
                    for (int i = index; i <= Count1; i++)
                    {
                        if (Count1 != i)
                        {
                            data[i] = data[i + 1];
                        }
                        else
                        {
                            data[i] = 0;
                        }
                    }
                    Count1--;
                }
                else
                {
                    Console.WriteLine("Index was outside the bounds of the array");
                }
            }
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < Count1; i++)
            {
                if (data[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("Array List Count is {0}",Count1);
        }

    }
}
