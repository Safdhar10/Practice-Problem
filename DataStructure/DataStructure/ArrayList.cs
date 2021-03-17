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
        private bool isSorted;
        public int Count { get => _count; set => _count = value; }
        public ArrayList(bool isSorted = false, int _capacity = 2)
        {
            this._capacity = _capacity;
            isEmpty = true;
            data = new int[_capacity];
            this.isSorted = isSorted;
        }
        public ArrayList(IEnumerable<int> Collection)
        {
            data = new int[_capacity];
            AddAll(Collection);
        }
        public ArrayList(IEnumerable<int> Collection, int StartIndex)
        {
            data = new int[_capacity];
            //for(int i=StartIndex;i<Collection.Count();i++)
            //{
            //    Add(Collection.ElementAt(i));
            //}
            int[] temp = Collection.ToArray();
            for(int i=StartIndex;i<temp.Count();i++)
            {
                Add(temp[i]);
            }
        }
        public ArrayList(IEnumerable<int> Collection, int StartIndex, int EndIndex)
        {
            data = new int[_capacity];
            //for (int i = StartIndex; i <=EndIndex; i++)
            //{
            //    Add(Collection.ElementAt(i));
            //}
            int[] temp = Collection.ToArray();
            for (int i = StartIndex; i <= EndIndex; i++)
            {
                Add(temp[i]);
            }
        }

        public void SetArrayState()
        {
            if (Count == 0)
            {
                isEmpty = true;
            }
            else
            {
                isEmpty = false;
            }
        }
        public string Print()
        {
            if (!isEmpty)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                for (int i = 0; i < Count - 1; i++)
                {
                    sb.Append(data[i] + ",");
                }
                sb.Append(data[Count - 1] + "]");
                return sb.ToString();
            }
            else
            {
                throw new Exception("arraylist is empty");
            }
        }

        public void Resize()
        {
            _capacity += 1;
            int[] newArray = new int[_capacity];
            newArray = data;
            data = new int[_capacity];
            Array.Copy(newArray, data, newArray.Length);

            //int[] oldArray = new int[_capacity];
            //Array.Copy(data, oldArray, _capacity);
            ////for(int i=0;i<Capacity1;i++)
            ////{
            ////    oldArray[i] = data[i];
            ////}
            //_capacity = (_capacity * 2);
            //data = new int[_capacity];
            ////for(int j=0;j<oldArray.Length;j++)
            ////{
            ////    data[j] = oldArray[j];
            ////}
            //Array.Copy(oldArray, data, oldArray.Length);
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
            if (!isEmpty)
            {
                if (index < Count && index >= 0)
                {
                    return data[index];
                }
                else
                {
                    throw new Exception("Index was outside the bounds of the array");
                }
            }
            else
            {
                throw new Exception("List is Empty");
            }
        }

        public void Set(int index, int value)
        {
            if (!isEmpty)
            {
                if (0 <= index && index < Count)
                {
                    data[index] = value;
                }
                else
                {
                    throw new Exception("Index was outside the bounds of the array ");
                }
            }
            else
            {
                throw new Exception("List is empty");
            }
        }

        public void Insert(int index, int value)
        {
            if (0 <= index && index <= Count)
            {
                if (Count == _capacity)
                {
                    Resize();
                }
                for (int i = Count; i > index; i--)
                {
                    data[i] = data[i - 1];
                }
                data[index] = value;
                Count++;
                SetArrayState();
            }
            else
            {
                throw new Exception("Index was outside the bound of the array");
            }

        }

        public void Delete(int index)
        {
            if (!isEmpty)
            {
                if (0 <= index && index < Count)
                {
                        
                        for (int i = index; i < Count-1; i++)
                        {
                                data[i] = data[i + 1];
                        }
                    data[Count-1] = 0;
                    Count--;
                    SetArrayState();
                }
                else
                {
                    throw new Exception("Index was outside the bounds of the array");
                }
            }
            else
            {
                throw new Exception("List is empty");
            }
        }

        public bool Contains(int value)
        {
            if (!isEmpty)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (data[i] == value)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                throw new Exception("List Is Empty");
            }
        }

        public void Resize(int NeedSpace)
        {
            _capacity += NeedSpace;
            int[] newArray = new int[_capacity];
            newArray = data;
            data = new int[_capacity];
            Array.Copy(newArray, data, newArray.Length);
        }
        public void AddAll(IEnumerable<int> collection)
        {
            //foreach(var v in collection)
            //{
            //    Add(v);
            //}

            int length = collection.Count();
            if((Count+length)>_capacity)
            {
                int NeedSize = (Count + length) - _capacity;
                Resize(NeedSize);
            }
            foreach(var items in collection)
            {
                data[Count] = items;
                Count++;
            }
            SetArrayState();
        }
        public void DeleteValue(int value, bool RemoveAll)
        {
            bool isItAvailble = false;
            if(!isEmpty)
            {
                if (!RemoveAll)
                {
                    for (int i = 0; i < Count; i++)
                    {
                        if (value == data[i])
                        {
                            isItAvailble = true;
                            Delete(i);
                            return;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Count; i++)
                    {
                        if (value == data[i])
                        {
                            isItAvailble = true;
                            Delete(i);
                            i--;
                        }
                    }
                }
                if(!isItAvailble)
                {
                    throw new NullReferenceException("Value does not exist in list");
                }
            }
            
        }

        public void InsertAll(int index,IEnumerable<int> collection)
        {
            if (!isEmpty)
            {
                //foreach(var v in  collection)
                //{
                //    Insert(index, v);
                //    index++;
                //}
                int[] array = collection.ToArray();
                int length = array.Length;
                if ((Count + length) > _capacity)
                {
                    int NeedSize = (Count + length) - _capacity;
                    Resize(NeedSize);
                }
                int _TempCapacity = _capacity;
                int _tempCount = Count;
                int _tempIndex = index + length;
                Count += length;
                while (_TempCapacity > index)
                {
                    _TempCapacity--;
                    _tempCount--;
                    if (_TempCapacity >= _tempIndex)
                    {
                        data[_TempCapacity] = data[_tempCount];
                    }
                    else
                    {
                        data[_TempCapacity] = array[length - 1];
                        length--;
                    }
                }
            }
            else
            {
                AddAll(collection);
            }
            SetArrayState();
        }

        public int Max()
        {
            if(!isEmpty)
            {
                int max = data[Count - 1];
                if (!isSorted)
                {
                    foreach (var tempMax in data)
                    {
                        if (tempMax > max)
                        {
                            max = tempMax;
                        }
                    }
                }
                return max;
            }
            else
            {
                throw new Exception("arraylist is empty");
            }

        }

        public int Min()
        {
            if(!isEmpty)
            {
                int min = data[0];
                if (!isSorted)
                {
                    foreach (var tempMin in data)
                    {
                        if (tempMin < min)
                        {
                            min = tempMin;
                        }
                    }
                }
                return min;
            }
            else
            {
                throw new Exception("arraylist is empty");
            }
        }

        public int Sum()
        {
            if(!isEmpty)
            {
                int sum = 0;
                foreach (var item in data)
                {
                    sum += item;
                }
                return sum;
            }
            else
            {
                throw new Exception("arraylist is empty");
            }
        }

        public ArrayList Reverse()
        {
            if(!isEmpty)
            {
                ArrayList newAl = new ArrayList();
                int i = Count - 1;
                while (i >= 0)
                {
                    newAl.Add(data[i]);
                    i--;
                }
                return newAl;
            }
            else
            {
                throw new Exception("arraylist is empty");
            }
        }

        public int[] Toarray()
        {
            if(!isEmpty)
            {
                int[] tempArray = new int[Count];
                for (int i = 0; i < Count; i++)
                {
                    tempArray[i] = Get(i);
                }
                return tempArray;
            }
            else
            {
                throw new Exception("arraylist is empty");
            }
        }

        public int[] Toarray(int StartIndex)
        {
            if(!isEmpty)
            {
                int size = Count - StartIndex;
                int[] tempArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    tempArray[i] = Get(StartIndex);
                    StartIndex++;
                }
                return tempArray;

            }
            else
            {
                throw new Exception("arraylist is empty");
            }
        }

        public int[] Toarray(int StartIndex, int EndIndex)
        {
            if(!isEmpty)
            { 
                int size = EndIndex;
                int[] tempArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    tempArray[i] = Get(StartIndex);
                    StartIndex++;
                }
                return tempArray;
            }
            else
            {
                throw new Exception("arraylist is empty");
            }
        }

        public void Clear()
        {
            ArrayList obj = new ArrayList();
            data = new int[obj._capacity];
            Count = 0;
            SetArrayState();
        }

        public ArrayList Sort(bool inDescendingOrder=false)
        {
            ArrayList Al = new ArrayList();
            Al.data = data;
            if(!isEmpty)
            {
                if(!inDescendingOrder)
                {
                    for (int i = 0; i < Count - 1; i++)
                    {
                        for (int j = i + 1; j < Count; j++)
                        {
                            if (Al.data[i] > Al.data[j])
                            {
                                int temp = Al.data[j];
                                Al.data[j] = Al.data[i];
                                Al.data[i] = temp;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Count - 1; i++)
                    {
                        for (int j = i + 1; j < Count; j++)
                        {
                            if (Al.data[i] < Al.data[j])
                            {
                                int temp = Al.data[j];
                                Al.data[j] = Al.data[i];
                                Al.data[i] = temp;
                            }
                        }
                    }

                }
                return Al;

            }
            else
            {
                throw new Exception("arraylist is empty");

            }
            
        }


    }
}
