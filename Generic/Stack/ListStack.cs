using Stack.Contracts;

namespace Stack;
public class ListStack<T> : IStack<T>
{
    private List<T> collection;
    private int Count => collection.Count;
    public ListStack()
    {
        collection = new List<T>();
    }
    public T Peek()
    {
        if(Count.Equals(0))
            return default(T);
        return collection[Count-1];
    }

    public T Pop()
    {
        if(Count.Equals(0))
            return default(T);
        var item = collection[Count-1];
        collection.RemoveAt(Count-1);
        return item;
    }

    public void Push(T item)
    {
        collection.Add(item);
    }
}
