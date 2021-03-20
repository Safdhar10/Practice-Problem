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
private int _first;
private int _last;
public DeqQueue(int Capacity)
{
    this._capacity = Capacity;
    _data = new T[Capacity];
    _count = 0;
    _first = -1;
    _last = -1;
}

public void InsertFirst(T value)
{
    if (_count == 0)
    {
        _last = 0;
    }
    if (_count < _capacity)
    {
        _data[++_first] = value;
        if (_first == _capacity - 1)
        {
            _first = 0;
        }
        _count++;
    }
    else
    {
        throw new OverflowException("Deque is Full");
    }
}
public void InsertLast(T value)
{
    if (_count == 0)
    {
        _first = 0;
    }
    if (_count < _capacity)
    {
        if (_last == 0)
        {
            _last = _data.Length;
        }
        _data[--_last] = value;
        _count++;

    }
    else
    {
        throw new OverflowException("Deque is Full");
    }
}
public T RemoveFirst()
{
    if (!IsEmpty)
    {
        if (_first == -1)
        {
            _first = _capacity - 1;
        }
        _count--;
        return _data[_first--];
    }
    else
    {
        throw new InvalidOperationException("Deque is Empty");
    }
}
public T RemoveLast()
{
    if (!IsEmpty)
    {
        if (_last == _capacity)
        {
            _last = 0;
        }
        _count--;
        return _data[_last++];
    }
    else
    {
        throw new InvalidOperationException("Deque is Empty");
    }
}
public T GetFirst()
{
    if (!IsEmpty)
    {
        return _data[_first];
    }
    else
    {
        throw new InvalidOperationException("Deque is Empty");
    }
}
public T GetLast()
{
    if (!IsEmpty)
    {
        return _data[_last];
    }
    else
    {
        throw new InvalidOperationException("Deque is Empty");
    }
}
